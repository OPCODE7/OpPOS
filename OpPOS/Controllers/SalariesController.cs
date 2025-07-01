﻿using System;
using System.Collections.Generic;
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
                    var query = from es in db.EMPLOYEE_SALARY
                                join s in db.SALARIES on es.SALARY_CODE equals s.SALARY_CODE
                                join e in db.EMPLOYEES on es.EMPLOYEE_CODE equals e.EMPLOYEE_CODE
                                where s.IS_DEL == isDel
                                select new SalaryDTO
                                {
                                    SALARY_CODE = s.SALARY_CODE,
                                    BASE_SALARY = s.BASE_SALARY,
                                    INCREASE = s.INCREASE,
                                    TOTAL_SALARY = s.TOTAL_SALARY,
                                    INSERTED_AT = s.INSERTED_AT,
                                    EMPLOYEE_CODE = e.EMPLOYEE_CODE,
                                    EMPLOYEE_NAME = e.EMPLOYEE_NAME + " " + e.EMPLOYEE_LASTNAME
                                };

                    var result = query.ToList();
                    if (!String.IsNullOrEmpty(searchFilter))
                    {
                        result = result.Where(s => s.SALARY_CODE.ToLower().Contains(searchFilter) || s.BASE_SALARY.ToString().ToLower().Contains(searchFilter) || s.INCREASE.ToString().ToLower().Contains(searchFilter) || s.TOTAL_SALARY.ToString().ToLower().Contains(searchFilter) || h.DoesDateMatch(s.INSERTED_AT, searchFilter) || s.EMPLOYEE_NAME.ToLower().Contains(searchFilter)).ToList();
                    }

                    salaries = result.ToList();

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
