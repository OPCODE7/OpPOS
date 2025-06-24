using OpPOS.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpPOS.Models;

namespace OpPOS.Controllers
{
    internal class SystemLicenseController
    {
        private Helpers.Helper h;

        public SystemLicenseController()
        {
            h = new Helpers.Helper();
        }

        public SYSTEM_LICENSE GetSystemLicense()
        {
            SYSTEM_LICENSE sl = new SYSTEM_LICENSE();
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    sl = db.SYSTEM_LICENSE.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());
            }

            return sl;
        }

        public int SaveSystemLicense(SYSTEM_LICENSE sl)
        {
            int result = 0;

            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.SYSTEM_LICENSE.Add(sl);
                    result = db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());

            }
            return result;

        }
    }
}
