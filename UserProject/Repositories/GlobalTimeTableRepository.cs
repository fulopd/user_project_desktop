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
    class GlobalTimeTableRepository : IDisposable
    {
        private userProjectDBContext db = new userProjectDBContext();


        public BindingList<user_data> proba()
        {
            db.user_data.Include("personal_data").Load();

            return db.user_data.Local.ToBindingList();

            //valami.ForEach(x => Debug.WriteLine(x.personal_data.first_name));

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
