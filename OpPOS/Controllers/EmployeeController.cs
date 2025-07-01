﻿using OpPOS.DTO;
using OpPOS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
                searchFilter = searchFilter.ToLower();
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    var query = db.EMPLOYEES
                     .Join(db.JOB_POSITIONS, emp => emp.JOB_POSITION_CODE, jps => jps.JOB_POSITION_CODE, (emp, jps) => new { emp, jps })
                     .Join(db.HORARY, ej => ej.emp.HORARY_CODE, hor => hor.HORARY_CODE, (ej, hor) => new
                     {
                         ej.emp.EMPLOYEE_CODE,
                         ej.emp.EMPLOYEE_DNI,
                         ej.emp.EMPLOYEE_NAME,
                         ej.emp.EMPLOYEE_LASTNAME,
                         ej.jps.DESCRIPTION_JOB_POSITION,
                         hor.INITIAL_HOUR,
                         hor.FINAL_HOUR,
                         hor.HORARY_DESCRIPTION,
                         ej.emp.EMPLOYEE_PHONE,
                         ej.emp.INSERTED_AT,
                         ej.emp.IS_DEL
                     });

                    // Filtrar por estado eliminado y código excluido (esto sí se puede en EF)
                    query = query.Where(emp => emp.IS_DEL == isDel && emp.EMPLOYEE_CODE != "EMP000001");

                    // Ejecutar query y traer los datos a memoria
                    var result = query.ToList();

                    if (!string.IsNullOrEmpty(searchFilter))
                    {
                        result = result.Where(emp =>
                            emp.EMPLOYEE_CODE.ToLower().Contains(searchFilter) ||
                            (emp.EMPLOYEE_NAME + " " + emp.EMPLOYEE_LASTNAME).ToLower().Contains(searchFilter) ||
                            emp.EMPLOYEE_DNI.ToLower().Contains(searchFilter) ||
                            emp.DESCRIPTION_JOB_POSITION.ToLower().Contains(searchFilter) ||
                            emp.EMPLOYEE_PHONE.ToLower().Contains(searchFilter) ||
                            emp.HORARY_DESCRIPTION.ToLower().Contains(searchFilter) ||
                           h.DoesDateMatch(emp.INSERTED_AT, searchFilter)
                        ).ToList();
                    }

                    return result.Select(emp => new EmployeeDTO
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
                h.MsgError("ERROR INESPERADO: " + ex.Message.ToUpper());
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
