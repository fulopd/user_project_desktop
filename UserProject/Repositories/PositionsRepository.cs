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
            db.position.OrderBy(x => x.priority).Load();
            return db.position.Local.ToBindingList();
        }

        public bool Exist(position param)
        {
            return db.position.Any(x => x.position_name == param.position_name);
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
