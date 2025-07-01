using OpPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpPOS.Controllers
{
    internal class EmployeeSalaryController
    {
        private Helpers.Helper h;

        public EmployeeSalaryController()
        {
            h = new Helpers.Helper();
        }

        public EMPLOYEE_SALARY GetLastEmployeeSalary(string salaryCode, string employeeCode, bool? salaryState, bool? isDel)
        {
            EMPLOYEE_SALARY salary = new EMPLOYEE_SALARY();

            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    var query = db.EMPLOYEE_SALARY.AsQueryable();

                    if (isDel != null) query = query.Where(x => x.IS_DEL == isDel);

                    if (salaryState != null)
                    {
                        query = query.Where(x => x.SALARY_STATE == salaryState).OrderByDescending(x => x.INSERTED_AT);
                    }



                    if (String.IsNullOrEmpty(employeeCode) && !String.IsNullOrEmpty(salaryCode))
                    {
                        salary = query.Where(x => x.SALARY_CODE == salaryCode).FirstOrDefault();
                    }
                    else if (!String.IsNullOrEmpty(employeeCode) && String.IsNullOrEmpty(salaryCode))
                    {
                        salary = query.Where(x => x.EMPLOYEE_CODE == employeeCode).FirstOrDefault();

                    }
                    else if (!String.IsNullOrEmpty(employeeCode) && !String.IsNullOrEmpty(salaryCode))
                    {
                        salary = query.Where(x => x.EMPLOYEE_CODE == employeeCode && x.SALARY_CODE == salaryCode).FirstOrDefault();
                    }



                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.ToString().ToUpper());
            }

            return salary;
        }

        public int SaveEmployeeSalary(EMPLOYEE_SALARY salary)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.EMPLOYEE_SALARY.Add(salary);
                    result = db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.ToString().ToUpper());
            }

            return result;

        }


        public int UpdateSalary(EMPLOYEE_SALARY salary)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.EMPLOYEE_SALARY.Attach(salary);
                    db.Entry(salary).State = System.Data.Entity.EntityState.Modified;
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.ToString().ToUpper());
            }

            return result;
        }



        public int DeleteEmployeeSalary(string id)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    EMPLOYEE_SALARY salary = db.EMPLOYEE_SALARY.Find(id);
                    db.Entry(salary).State = System.Data.Entity.EntityState.Deleted;
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
