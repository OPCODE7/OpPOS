using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpPOS.Models;

namespace OpPOS.Controllers
{
    internal class DataBaseController
    {
        Helpers.Helper h;
        public DataBaseController()
        {
            h = new Helpers.Helper();
        }

        public int GetNextIdModule(string tableName)
        {
            int lastIdModule = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    lastIdModule = (int)db.Database.SqlQuery<decimal>($"SELECT IDENT_CURRENT('{tableName}') + 1").FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                h.MsgError(ex.ToString());
            }
            return lastIdModule;
        }

        public bool HasReferences<T>(DbContext db, DbSet<T> table, Expression<Func<T, bool>> predicate) where T : class
        {
            return table.Any(predicate);
        }

    }
}
