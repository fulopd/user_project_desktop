using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Repositories;
using UserProject.ViewInterfaces;
using UserProject.ViewModels;

namespace UserProject.Presenters
{
    class UserDetailsListPresenter
    {
        private IUserDetailsListView view;
        //private UserDetailsVMRepository repo = new UserDetailsVMRepository();

        public UserDetailsListPresenter(IUserDetailsListView param)
        {
            view = param;
        }

        public void LoadData()
        {
            using (UserDetailsVMRepository repo = new UserDetailsVMRepository())
            {
                view.bindingList = repo.GetAllRendelesVM(
                view.pageNumber, view.itemsPerPage, view.search, view.sortBy, view.ascending, view.active);
                view.totalItems = repo.Count();
            }

        }

        public void Add(UserDetailsViewModel param)
        {
            view.bindingList.Add(param);
        }

        public void Modify(int rowIndex, UserDetailsViewModel param)
        {
            view.bindingList[rowIndex] = param;
        }

        public void Remove(int rowIndex, UserDetailsViewModel param) 
        {
            using (UserDataRepository userRepo = new UserDataRepository())
            {
                userRepo.Delete(param.userDataId);
                userRepo.Save();
            }

            using (PersonalDataRepository personalRepo = new PersonalDataRepository())
            {                
                personalRepo.Delete(param.personalDataId);
                personalRepo.Save();
            }

            view.bindingList.RemoveAt(rowIndex);
        }
    }
}
