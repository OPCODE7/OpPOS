using OpPOS.Helpers;
using OpPOS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OpPOS.Controllers
{
    internal class SupplierController
    {
        Helper h;
        public SupplierController() {
            h = new Helper();
        }

        public List<SUPPLIERS> GetSuppliers(string searchFilter, bool isDel)
        {
            List<SUPPLIERS> suppliers = new List<SUPPLIERS>();

            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    var searchParam = new SqlParameter("@SearchFilter", string.IsNullOrWhiteSpace(searchFilter) ? (object)DBNull.Value : searchFilter);
                    var isDelParam = new SqlParameter("@IsDel", isDel);

                    suppliers = db.Database.SqlQuery<SUPPLIERS>(
                        "EXEC SP_GET_SUPPLIERS @SearchFilter, @IsDel",
                        searchParam,
                        isDelParam
                    ).ToList();
                }
            }
            catch (SqlException ex)
            {
                h.MsgError("ERROR EN LA BASE DE DATOS: " + ex.Message.ToUpper());
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());
            }

            return suppliers;
        }


        public SUPPLIERS GetSupplier(string codSupplier)
        {
            SUPPLIERS supplier = new SUPPLIERS();
            try
            {
                using (OpPOSEntities db= new OpPOSEntities())
                {
                    supplier = db.SUPPLIERS.Find(codSupplier);
                }
            }
            catch (SqlException ex)
            {
                h.MsgError("ERROR EN LA BASE DE DATOS: " + ex.Message.ToUpper());

            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());
            }

            return supplier;
        }

        public int SaveSupplier(SUPPLIERS newSupplier)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.SUPPLIERS.Add(newSupplier);
                    result = db.SaveChanges();
                }
            }
            catch (SqlException ex)
            {
                h.MsgError("ERROR EN LA BASE DE DATOS: " + ex.ToString().ToUpper());

            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.ToString().ToUpper());
            }

            return result;
        }

        public int UpdateSupplier(SUPPLIERS supplier)
        {
            int result = 0;
            try
            {
                using(OpPOSEntities db= new OpPOSEntities())
                {
                    db.Entry(supplier).State = System.Data.Entity.EntityState.Modified;
                    result= db.SaveChanges();
                }

            }
            catch (SqlException ex)
            {
                h.MsgError("ERROR EN LA BASE DE DATOS: " + ex.Message.ToUpper());

            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());
            }
            return result;
        }

        public int DeleteSupplier(string codSupplier)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    SUPPLIERS supplier = db.SUPPLIERS.Find(codSupplier);
                    db.Entry(supplier).State = System.Data.Entity.EntityState.Deleted;
                    result = db.SaveChanges();
                }

            }
            catch (SqlException ex)
            {
                h.MsgError("ERROR EN LA BASE DE DATOS: " + ex.Message.ToUpper());

            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());
            }

            return result;

        }
    }
}
