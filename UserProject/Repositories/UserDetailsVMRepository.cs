using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;
using UserProject.ViewModels;

namespace UserProject.Repositories
{
    class UserDetailsVMRepository : IDisposable
    {
        private userProjectDBContext db = new userProjectDBContext();
        private int _totalItems;
        private DateTime date = DateTime.Now; 

        public BindingList<UserDetailsViewModel> GetAllRendelesVM(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true,
            bool active = true)
        {
            var query = db.user_data.OrderBy(x => x.id).AsQueryable();

            //aktív / inaktív dolgozók
            if (active)
            {
                query = query.Where(x => x.last_working_day == null || x.last_working_day >= date.Date);//active
            }
            else
            {
                query = query.Where(x => x.last_working_day != null || x.last_working_day <= date.Date);//inactive
            }
            
           
            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                query = query.Where(x => x.personal_data.first_name.ToLower().Contains(search) ||
                                         x.personal_data.last_name.ToLower().Contains(search) ||
                                         x.personal_data.location.ToLower().Contains(search) ||
                                         x.personal_data.email.ToLower().Contains(search) ||
                                         x.user_name.ToLower().Contains(search) ||
                                         x.position.position_name.ToLower().Contains(search));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    default:
                        query = ascending ? query.OrderBy(x => x.id) : query.OrderByDescending(x => x.id);
                        break;                    
                    case "position":
                        query = ascending ? query.OrderBy(x => x.position.position_name) : query.OrderByDescending(x => x.position.position_name);
                        break;
                    case "firstname":
                        query = ascending ? query.OrderBy(x => x.personal_data.first_name) : query.OrderByDescending(x => x.personal_data.first_name);
                        break;
                    case "lastname":
                        query = ascending ? query.OrderBy(x => x.personal_data.last_name) : query.OrderByDescending(x => x.personal_data.last_name);
                        break;
                    case "location":
                        query = ascending ? query.OrderBy(x => x.personal_data.location) : query.OrderByDescending(x => x.personal_data.location);
                        break;
                    case "email":
                        query = ascending ? query.OrderBy(x => x.personal_data.email) : query.OrderByDescending(x => x.personal_data.email);
                        break;
                    case "phone":
                        query = ascending ? query.OrderBy(x => x.personal_data.phone) : query.OrderByDescending(x => x.personal_data.phone);
                        break;
                    case "birth":
                        query = ascending ? query.OrderBy(x => x.personal_data.birth_date) : query.OrderByDescending(x => x.personal_data.birth_date);
                        break;
                    case "mother":
                        query = ascending ? query.OrderBy(x => x.personal_data.mother) : query.OrderByDescending(x => x.personal_data.mother);
                        break;
                    case "user":
                        query = ascending ? query.OrderBy(x => x.user_name) : query.OrderByDescending(x => x.user_name);
                        break;
                }
            }


            // Összes találat kiszámítása
            _totalItems = query.Count();

            // Oldaltördelés
            if (page + itemsPerPage > 0)
            {
                query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);
            }

            var userDetailsVMList = new List<UserDetailsViewModel>();
            var dbList = query.ToList();
            foreach (user_data item in dbList)
            {                
                userDetailsVMList.Add(new UserDetailsViewModel(
                    item.id,
                    item.user_name,
                    item.personal_data.id,
                    item.personal_data.first_name,
                    item.personal_data.last_name,
                    item.personal_data.mother,
                    item.personal_data.birth_date,
                    item.personal_data.location,
                    item.personal_data.email,
                    item.personal_data.phone,
                    item.personal_data.picture,
                    item.position.id,
                    item.position.position_name
                    ));
            }
            return new BindingList<UserDetailsViewModel>(userDetailsVMList);
        }

        public int Count()
        {
            return _totalItems;
        }


        //public void Insert(UserDetailsViewModel param)
        //{
        //    personal_data tempPersonal = new personal_data(
        //                                param.personalDataFirst_name,
        //                                param.personalDataLast_name,
        //                                param.personalDataMother,
        //                                param.personalDataBirth_date,
        //                                param.personalDataLocation,
        //                                param.personalDataEmail,
        //                                param.personalDataPhone,
        //                                param.personalDataPicture);

        //    user_data tempUserData = new user_data(param.userDataUser_name,)
        //    var rendeles = new rendeles(
        //                param.ugyfelId,
        //                param.jarmuId,
        //                param.rendelesDatum
        //                );
        //    db.rendeles.Add(rendeles);
        //}

        //public void Delete(int id)
        //{
        //    var rendeles = db.rendeles.Find(id);
        //    db.rendeles.Remove(rendeles);
        //    db.SaveChanges();
        //}

        //// HACK: RendelesRepo Update

        //public void Update(rendelesVM rendelesVM)
        //{
        //    var rendeles = db.rendeles.Find(rendelesVM.rendelesId);
        //    if (rendeles != null)
        //    {
        //        rendeles.ugyfel.id = rendelesVM.ugyfelId;
        //        rendeles.jarmu_id = rendelesVM.jarmuId;
        //        rendeles.datum = rendelesVM.rendelesDatum;
        //        db.Entry(rendeles).State = EntityState.Modified;
        //    }
        //}

        public void Save()
        {
            db.SaveChanges();
        }

        public bool Exists(UserDetailsViewModel userDetails)
        {
            return db.user_data.Any(x => x.id == userDetails.userDataId);
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