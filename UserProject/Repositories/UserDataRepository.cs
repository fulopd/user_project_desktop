using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;
using UserProject.Services;

namespace UserProject.Repositories
{
    class UserDataRepository : IDisposable
    {
        //private userProjectDBContext db = new userProjectDBContext();
        private userProjectDBContext db;

        public UserDataRepository(userProjectDBContext db)
        {
            this.db = db;
        }
       
        public bool Exists(user_data user)
        {
            return db.user_data.Any(x => x.id == user.id);
        }

        public void Insert(user_data user)
        {
            if (db.user_data.Any(x => x.id == user.id))
            {
                throw new Exception("Már létezik ilyen id!");
            }
            db.user_data.Add(user);
        }

        public void Delete(int id)
        {
            var user = db.user_data.Find(id);
            db.user_data.Remove(user);
        }

        public void Update(user_data param)
        {
            var user = db.user_data.Find(param.id);
            if (user != null)
            {
                //db.Entry(user).CurrentValues.SetValues(param);                
                user.user_name = param.user_name;
                user.password = param.password;
                user.first_working_day = param.first_working_day;
                user.last_working_day = param.last_working_day;
                user.position_id = param.position_id;
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
