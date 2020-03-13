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


        public List<user_data> proba()
        {
            //db.user_data.Include(x => x.personal_data.first_name).Load();
            //var asd = db.user_data.Include(x => x.position.position_name).ToList();
            return db.user_data.ToList();

            //valami.ForEach(x => Debug.WriteLine(x.personal_data.first_name));

        }

        public bool Exists(time_table param)
        {
            return db.time_table.Any(x => x.user_id == param.user_id && x.start_date == param.start_date);
        }

        public void Insert(time_table param)
        {
            if (Exists(param))
            {
                throw new Exception("Már létezik ilyen id!");
            }
            db.time_table.Add(param);
        }

        public void Delete(int id)
        {
            var timePoint = db.time_table.Find(id);
            db.time_table.Remove(timePoint);
        }

        public void Update(time_table param)
        {
            var timePoint = db.time_table.Find(param.id);
            if (timePoint != null)
            {
                db.Entry(timePoint).CurrentValues.SetValues(param);                
                //user.user_name = param.user_name;
                //user.password = param.password;
                //user.first_working_day = param.first_working_day;
                //user.last_working_day = param.last_working_day;
                //user.position_id = param.position_id;
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
