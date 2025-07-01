using OpPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpPOS.Controllers
{
    internal class RolePermissionsController
    {
        Helpers.Helper h;
        public RolePermissionsController()
        {
            h = new Helpers.Helper();
        }


        public IEnumerable<dynamic> GetPermissionsByRole(int roleId)
        {
            IEnumerable<dynamic> lst = new List<dynamic>();
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    var query = from rp in db.ROLE_PERMISSIONS
                                join r in db.USER_ROLES on rp.ROLE_ID equals r.ROLE_ID
                                join p in db.USER_PERMISSIONS on rp.PERMISSION_ID equals p.PERMISSION_ID
                                join m in db.APP_MODULES on p.MODULE_ID equals m.MODULE_ID
                                where rp.ROLE_ID == roleId
                                select new
                                {
                                    rp.ROLE_PERMISSION_ID,
                                    p.PERMISSION_ID,
                                    p.MODULE_ID,
                                    r.ROLE_ID,
                                    r.ROLE_NAME,
                                    m.MODULE_NAME,
                                    p.ACTION
                                };
                    lst = query.ToList();
                }
            }
            catch (Exception ex)
            {
                h.MsgError(ex.ToString());
            }
            return lst;

        }

        public int SaveRolePermission(ROLE_PERMISSIONS rp)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.ROLE_PERMISSIONS.Add(rp);
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                h.MsgError(ex.ToString());
            }
            return result;
        }

        public ROLE_PERMISSIONS GetRolePermission(int roleId, int permissionId)
        {
            ROLE_PERMISSIONS rp = new ROLE_PERMISSIONS();
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    rp = db.ROLE_PERMISSIONS.Where(r => r.ROLE_ID == roleId && r.PERMISSION_ID == permissionId).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                h.MsgError(ex.ToString());
            }
            return rp;

        }

        public int DeleteRolePermission(ROLE_PERMISSIONS rp)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.Entry(rp).State = System.Data.Entity.EntityState.Deleted;
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                h.MsgError(ex.ToString());
            }
            return result;
        }
    }
}
