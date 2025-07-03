using OpPOS.DTO;
using OpPOS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OpPOS.Controllers
{
    internal class EmployeeController
    {
        private EMPLOYEES employee;
        private Helpers.Helper h = new Helpers.Helper();
        public EmployeeController()
        {
            employee = new EMPLOYEES();
        }

        public IEnumerable<EmployeeDTO> GetEmployees(string searchFilter = "", bool isDel = false)
        {
            try
            {
         
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    var searchParam = new SqlParameter("@SearchFilter", string.IsNullOrWhiteSpace(searchFilter) ? (object)DBNull.Value : searchFilter);
                    var isDelParam = new SqlParameter("@IsDel", isDel);

                    var query = db.Database.SqlQuery<EmployeeDTO>(
                         "EXEC SP_GET_EMPlOYEES @SearchFilter, @IsDel",
                         searchParam,
                         isDelParam

                     ).ToList();


                    return query.Select(emp => new EmployeeDTO
                    {
                        EMPLOYEE_CODE = emp.EMPLOYEE_CODE,
                        EMPLOYEE_DNI = emp.EMPLOYEE_DNI,
                        EMPLOYEE_NAME = emp.EMPLOYEE_NAME,
                        EMPLOYEE_LASTNAME = emp.EMPLOYEE_LASTNAME,
                        EMPLOYEE_FULL_NAME = emp.EMPLOYEE_NAME + " " + emp.EMPLOYEE_LASTNAME,
                        DESCRIPTION_JOB_POSITION = emp.DESCRIPTION_JOB_POSITION,
                        INITIAL_HOUR = emp.INITIAL_HOUR,
                        FINAL_HOUR = emp.FINAL_HOUR,
                        HORARY_DESCRIPTION = emp.HORARY_DESCRIPTION,
                        EMPLOYEE_PHONE = emp.EMPLOYEE_PHONE,
                        INSERTED_AT = emp.INSERTED_AT,
                        IS_DEL = emp.IS_DEL
                    }).ToList();

                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.ToString().ToUpper());
            }

            return Enumerable.Empty<EmployeeDTO>();
        }

        public EMPLOYEES GetEmployee(string id)
        {
            EMPLOYEES employee = new EMPLOYEES();
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    employee = db.EMPLOYEES.Where(e => e.EMPLOYEE_CODE == id).FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                h.MsgError(ex.ToString());
            }
            return employee;

        }

        public int SaveEmployee(EMPLOYEES employee)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.EMPLOYEES.Add(employee);
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                h.MsgError(ex.ToString());
            }
            return result;
        }

        public int UpdateEmployee(EMPLOYEES employee)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.Entry(employee).State = EntityState.Modified;
                    result = db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                h.MsgError(ex.ToString());
            }
            return result;
        }

        public int DeleteEmployee(EMPLOYEES employee)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.EMPLOYEES.Attach(employee);
                    db.EMPLOYEES.Remove(employee);
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
