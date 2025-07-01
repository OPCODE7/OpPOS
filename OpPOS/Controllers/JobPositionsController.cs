using OpPOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpPOS.Controllers
{
    internal class JobPositionsController: DataBaseController
    {
        private JOB_POSITIONS jobPosition;
        Helpers.Helper h = new Helpers.Helper();
        public JobPositionsController()
        {
            jobPosition = new JOB_POSITIONS();
        }

        public List<JOB_POSITIONS> GetJobPositions(string searchFilter, bool isDel)
        {
            List<JOB_POSITIONS> jobPositions = new List<JOB_POSITIONS>();
            searchFilter = searchFilter.ToLower();
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    var query = db.JOB_POSITIONS.Where(j => j.IS_DEL == isDel).ToList();

                    if (!String.IsNullOrEmpty(searchFilter))
                    {
                        query = query.Where(j => j.JOB_POSITION_CODE.ToLower().Contains(searchFilter) || j.DESCRIPTION_JOB_POSITION.ToLower().Contains(searchFilter) || h.DoesDateMatch(j.INSERTED_AT, searchFilter)).ToList();
                    }

                    jobPositions = query.ToList();
                }
            }
            catch (SqlException ex)
            {
                h.MsgError("ERROR EN LA BASE DE DATOS: " + ex.Message.ToUpper());

            }
            catch (Exception ex)
            {
                h.MsgError(ex.Message);
            }
            return jobPositions;
        }

        public JOB_POSITIONS GetJobPosition(string id)
        {
            JOB_POSITIONS jps = new JOB_POSITIONS();
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    jps = db.JOB_POSITIONS.Find(id);
                }
            }
            catch (SqlException ex)
            {
                h.MsgError("ERROR EN LA BASE DE DATOS: " + ex.Message.ToUpper());

            }
            catch (Exception ex)
            {
                h.MsgError(ex.ToString());
            }
            return jps;
        }

        public int SaveJobPosition(JOB_POSITIONS jps)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.JOB_POSITIONS.Add(jps);
                    result = db.SaveChanges();
                }
            }
            catch (SqlException ex)
            {
                h.MsgError("ERROR EN LA BASE DE DATOS: " + ex.Message.ToUpper());

            }
            catch (Exception ex)
            {
                h.MsgError(ex.Message);
            }
            return result;
        }

        public int UpdateJobPosition(JOB_POSITIONS jps)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    db.Entry(jps).State = System.Data.Entity.EntityState.Modified;
                    result = db.SaveChanges();
                }
            }
            catch (SqlException ex)
            {
                h.MsgError("ERROR EN LA BASE DE DATOS: " + ex.Message.ToUpper());

            }
            catch (Exception ex)
            {
                h.MsgError(ex.Message);
            }
            return result;
        }

        public int DeleteJobPosition(JOB_POSITIONS jps)
        {
            int result = 0;
            try
            {
                using (OpPOSEntities db = new OpPOSEntities())
                {
                    if (HasReferences(db, db.EMPLOYEES, e => e.JOB_POSITION_CODE == jps.JOB_POSITION_CODE))
                    {
                        h.MsgError(Helpers.App.Msg0019);
                        return 0;
                    }

                    db.JOB_POSITIONS.Attach(jps);
                    db.JOB_POSITIONS.Remove(jps);
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
