using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;

namespace UserProject.Repositories
{
    class TimeTableRepository : IDisposable
    {
        private userProjectDBContext db = new userProjectDBContext();
        

        public bool Exists(time_table param)
        {
            return db.time_table.Any(x => x.user_id == param.user_id &&
                                        x.start_date.Year == param.start_date.Year &&
                                        x.start_date.Month == param.start_date.Month &&
                                        x.start_date.Day == param.start_date.Day
                                        );
        }

        public void Insert(time_table param)
        {
            if (Exists(param))
            {
                throw new Exception("Már létezik ilyen id!");
            }
            db.time_table.Add(param);
        }

        public void Delete(time_table param)
        {           
            var timePoint = db.time_table.SingleOrDefault(
                                           x => x.user_id == param.user_id &&
                                           x.start_date.Year == param.start_date.Year &&
                                           x.start_date.Month == param.start_date.Month &&
                                           x.start_date.Day == param.start_date.Day
                                           );

            db.time_table.Remove(timePoint);
        }

        public void Update(time_table param)
        {
            var timePoint = db.time_table.SingleOrDefault(
                                        x => x.user_id == param.user_id &&
                                        x.start_date.Year == param.start_date.Year &&
                                        x.start_date.Month == param.start_date.Month &&
                                        x.start_date.Day == param.start_date.Day
                                        );
            if (timePoint != null)
            {
                //TODO: Módosítás szebben?
                //db.Entry(timePoint).CurrentValues.SetValues(param);    
                if (timePoint.start_date.Hour != param.start_date.Hour || timePoint.end_date.Hour != param.end_date.Hour)
                {
                    timePoint.user_id = param.user_id;
                    timePoint.start_date = param.start_date;
                    timePoint.end_date = param.end_date;
                    timePoint.paid_leave = param.paid_leave;
                    timePoint.sick_leave = param.sick_leave;
                    timePoint.update_at = param.update_at;
                    Debug.Write("update");
                }

            }
        }


        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
        }
    }
}
