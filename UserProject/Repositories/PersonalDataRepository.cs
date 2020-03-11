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
    class PersonalDataRepository : IDisposable
    {
        //private userProjectDBContext db = new userProjectDBContext();
        private userProjectDBContext db;
        private int _totalItems;

        public PersonalDataRepository(userProjectDBContext db)
        {
            this.db = db;
        }

        public BindingList<personal_data> GetAllUserPersonalData(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            // AsQueryable == Még nem fogja lefuttatni a C#, csak ToList esetén
            var query = db.personal_data.OrderBy(x => x.id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {                
                search = search.ToLower();
                

                // ToString(), Convert és társai nem fognak működni 
                // mert SQL lekérdezés lesz belőle
                query = query.Where(x =>
                    x.first_name.ToLower().Contains(search) ||
                    x.last_name.ToLower().Contains(search) ||
                    x.email.ToLower().Contains(search) ||
                    x.location.ToLower().Contains(search)                   
                    );
                                
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                // Több oszlop esetén feltételekkel kell megvizsálni a sortBy értékét
                switch (sortBy)
                {
                    case "id":
                        query = ascending ? query.OrderBy(x => x.id) : query.OrderByDescending(x => x.id);
                        break;
                    case "first_name":
                        query = ascending ? query.OrderBy(x => x.first_name) : query.OrderByDescending(x => x.first_name);
                        break;
                    case "last_name":
                        query = ascending ? query.OrderBy(x => x.last_name) : query.OrderByDescending(x => x.last_name);
                        break;
                    case "location":
                        query = ascending ? query.OrderBy(x => x.location) : query.OrderByDescending(x => x.location);
                        break;                    
                    default:
                        break;
                }
            }

            // Összes találat kiszámítása
            _totalItems = query.Count();

            // Oldaltördelés
            if (page + itemsPerPage > 0)
            {
                // Skip = ugrás
                // Take = Hátralévő elemek megjelenítése
                query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);
            }

            return new BindingList<personal_data>(query.ToList());
        }
        public void RefreshDB()
        {
            foreach (var item in db.ChangeTracker.Entries())
            {
                item.Reload();
            }
        }
        public int CountPersonalData()
        {
            return _totalItems;
        }

        public bool Exists(personal_data peronal)
        {
            return db.personal_data.Any(x => x.id == peronal.id);
        }

        public int GetPersonalDataId(personal_data param) 
        {
            var pd = db.personal_data.SingleOrDefault(x => x.mother == param.mother && x.phone == param.phone && x.location == param.location);
            return pd.id;
        }
        public void Insert(personal_data param)
        {
            if (db.personal_data.Any(x => x.id == param.id))
            {
                throw new Exception("Már létezik ilyen id!");
            }
            db.personal_data.Add(param);
        }

        public void Delete(int id)
        {
            var personal = db.personal_data.Find(id);
            db.personal_data.Remove(personal);
        }

        public void Update(personal_data param)
        {
            var personal = db.personal_data.Find(param.id);
            if (personal != null)
            {
                db.Entry(personal).CurrentValues.SetValues(param);
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