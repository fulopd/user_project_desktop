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
    class PositionsRepository : IDisposable
    {
        private userProjectDBContext db = new userProjectDBContext();

        public BindingList<position> getAllPositions()
        {
            db.position.Load();
            return db.position.Local.ToBindingList();
        }

        public void save()
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
