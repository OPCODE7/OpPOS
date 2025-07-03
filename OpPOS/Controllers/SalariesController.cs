using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpPOS.DTO;
using OpPOS.Models;

namespace OpPOS.Controllers
{
    internal class SalariesController
    {
        private Helpers.Helper h;

        public SalariesController()
        {
            h = new Helpers.Helper();
        }

        public List<SalaryDTO> GetSalaries(string searchFilter, bool isDel)
        {
            List<SalaryDTO> salaries = new List<SalaryDTO>();

            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    var searchParam = new SqlParameter("@SearchFilter", string.IsNullOrWhiteSpace(searchFilter) ? (object)DBNull.Value : searchFilter);
                    var isDelParam = new SqlParameter("@IsDel", isDel);

                    var query = db.Database.SqlQuery<SalaryDTO>(
                         "EXEC SP_GET_SALARIES @SearchFilter, @IsDel",
                         searchParam,
                         isDelParam

                     ).ToList();

                    salaries = query.Select(sal => new SalaryDTO
                    {
                        SALARY_CODE = sal.SALARY_CODE,
                        BASE_SALARY= sal.BASE_SALARY,
                        INCREASE= sal.INCREASE,
                        TOTAL_SALARY= sal.TOTAL_SALARY,
                        EMPLOYEE_NAME= sal.EMPLOYEE_NAME +" " + sal.EMPLOYEE_LASTNAME,
                        INSERTED_AT = sal.INSERTED_AT,
                    }).ToList();

                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());
            }

            return salaries;
        }

        public SALARIES GetSalary(string salaryId)
        {
            SALARIES salary = new SALARIES();
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                { 
                    salary = db.SALARIES.Find(salaryId);
                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());
            }

            return salary;
        }


        public int SaveSalary(SALARIES salary)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.SALARIES.Add(salary);
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.ToString().ToUpper());
            }

            return result;

        }

        public int UpdateSalary(SALARIES salary)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.Entry(salary).State = System.Data.Entity.EntityState.Modified;
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());
            }

            return result;
        }

        public int DeleteSalary(string salaryCode)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db= new OpPOSEntities())
                {
                    SALARIES salary = db.SALARIES.Find(salaryCode);
                    db.Entry(salary).State = System.Data.Entity.EntityState
                        .Deleted;
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
