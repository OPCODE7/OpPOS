using OpPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpPOS.DTO;

namespace OpPOS.Controllers
{
    internal class LogBookAppController
    {
        private Helpers.Helper h;
        public LogBookAppController()
        {
            h = new Helpers.Helper();
        }

        public List<LOGBOOK_APP> GetLogs(string searchFilter)
        {

            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    searchFilter = searchFilter.ToLower();
                    var query = db.LOGBOOK_APP.OrderByDescending(x => x.INSERTED_AT).ToList();

                    if (!String.IsNullOrEmpty(searchFilter))
                    {
                        query = query.Where(x => x.LOG_DESCRIPTION.ToLower().Contains(searchFilter) || x.LOG_ID.ToString().ToLower().Contains(searchFilter) || h.DoesDateMatch(x.INSERTED_AT, searchFilter)).ToList();

                    }

                    return query.ToList();

                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());
                return null;
            }
        }

        public LogBookDTO getLog(long logId)
        {
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    var query = from log in db.LOGBOOK_APP
                                join user in db.USERS on log.USER_CODE equals user.USER_CODE
                                join module in db.APP_MODULES on log.MODULE_ID equals module.MODULE_ID
                                where log.LOG_ID == logId
                                select new LogBookDTO
                                {
                                    LOG_ID = log.LOG_ID,
                                    USER_CODE = log.USER_CODE,
                                    USER_NAME = user.USER_NAME,
                                    ACTION_TYPE = log.ACTION_TYPE,
                                    LOG_DESCRIPTION = log.LOG_DESCRIPTION,
                                    MODULE_ID = log.MODULE_ID,
                                    MODULE_NAME = module.MODULE_NAME,
                                    INSERTED_AT = log.INSERTED_AT
                                };
                    return query.FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());
                return null;
            }

        }

        public async Task saveLog(string userCode, string actionType, string logDescription, string module, DateTime insertedAt)
        {
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    await db.Database.ExecuteSqlCommandAsync(
                    "EXEC LogAction @UserCode = {0}, @ActionType = {1}, @LogDescription = {2}, @Module = {3}, @InsertedAt = {4}",
                    userCode, actionType, logDescription, module, insertedAt
                    );
                }

            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());

            }
        }
    }
}
