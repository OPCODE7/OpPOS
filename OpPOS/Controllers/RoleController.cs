using OpPOS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpPOS.Controllers
{
    internal class RoleController
    {
        Helpers.Helper h = new Helpers.Helper();
        private USER_ROLES role;
        public RoleController()
        {
            role = new USER_ROLES();

        }

        public List<USER_ROLES> getRoles(string searchFilter, bool isDel)
        {
            List<USER_ROLES> lst = new List<USER_ROLES>();
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    var query = db.USER_ROLES.Where(r => r.IS_DEL == isDel).ToList();

                    if (!string.IsNullOrEmpty(searchFilter))
                    {
                        query = query.Where(r => r.ROLE_ID.ToString().ToLower().Contains(searchFilter) || r.ROLE_NAME.ToLower().Contains(searchFilter) || r.DESCRIPTION_ROLE.ToLower().Contains(searchFilter) || h.DoesDateMatch(r.INSERTED_AT, searchFilter)).ToList();
                    }

                    lst = query.OrderBy(r => r.ROLE_ID).ToList();
                }
            }

            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());

            }
            return lst;

        }

        public USER_ROLES getRole(int roleId)
        {
            USER_ROLES role = new USER_ROLES();
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    role = db.USER_ROLES.Find(roleId);
                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message);
            }
            return role;

        }

        public int saveRole(USER_ROLES role)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.USER_ROLES.Add(role);
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message);
            }
            return result;
        }

        public int updateRole(USER_ROLES role)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.Entry(role).State = EntityState.Modified;
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message);
            }
            return result;
        }

        public int deleteRole(USER_ROLES role)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.USER_ROLES.Attach(role);
                    db.USER_ROLES.Remove(role);
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message);
            }
            return result;
        }
    }
}
