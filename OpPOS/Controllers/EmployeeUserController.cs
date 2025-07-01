﻿using OpPOS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpPOS.Controllers
{
    internal class EmployeeUserController
    {
        private EMPLOYEE_USER employeeUserModel;
        private Helpers.Helper h;
        public EmployeeUserController()
        {
            employeeUserModel = new EMPLOYEE_USER();
            h = new Helpers.Helper();
        }

        public IEnumerable<dynamic> GetEmployeeUsers(string searchFilter)
        {
            List<dynamic> employeeUsers = new List<dynamic>();

            return employeeUsers;

        }

        public EMPLOYEE_USER getEmployeeUser(string id)
        {
            EMPLOYEE_USER employeeUser = new EMPLOYEE_USER();
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    employeeUser = db.EMPLOYEE_USER.Where(e => e.USER_CODE == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                h.MsgError(ex.Message);
            }

            return employeeUser;
        }

        public int saveEmployeeUser(EMPLOYEE_USER employeeUser)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.EMPLOYEE_USER.Add(employeeUser);
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                h.MsgError(ex.Message);
            }

            return result;
        }

        public int updateEmployeeUser(EMPLOYEE_USER employeeUser)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.Entry(employeeUser).State = EntityState.Modified;
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                h.MsgError(ex.ToString());
            }

            return result;
        }

        public int deleteEmployeeUser(EMPLOYEE_USER employeeUser)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.EMPLOYEE_USER.Attach(employeeUser);
                    db.EMPLOYEE_USER.Remove(employeeUser);
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
