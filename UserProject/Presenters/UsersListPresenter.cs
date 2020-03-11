using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;
using UserProject.Repositories;
using UserProject.ViewInterfaces;

namespace UserProject.Presenters
{
    class UsersListPresenter
    {
        IUsersListView view;
        private static userProjectDBContext db = new userProjectDBContext();
        PersonalDataRepository personalRepo = new PersonalDataRepository(db);
        UserDataRepository userRepo = new UserDataRepository(db);
        
        public UsersListPresenter(IUsersListView param)
        {
            view = param;
        }

        public void LoadData() 
        {            
            personalRepo.RefreshDB();//Másik DBContextben törlök / módosítok azért kell???? Jobb megoldás??
            view.userBindingList = personalRepo.GetAllUserPersonalData(
                view.pageNumber,
                view.itemsPerPage,
                view.search,
                view.sortBy,
                view.ascending);
            view.totalItems = personalRepo.CountPersonalData();

        }
       
        public void Remove(int index)
        {
            var pd = view.userBindingList.ElementAt(index);
            view.userBindingList.RemoveAt(index);
            var ud = pd.user_data.SingleOrDefault(x=>x.personal_data_id == pd.id);           
            if (pd.id > 0 && ud.id > 0)
            {                
                userRepo.Delete(ud.id);                
                personalRepo.Delete(pd.id);
                Save();

            }
        }
        
        public void Save()
        {            
            userRepo.Save();            
            personalRepo.Save();            
        }
    }
}
