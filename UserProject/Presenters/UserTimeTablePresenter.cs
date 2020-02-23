using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Repositories;
using UserProject.ViewInterfaces;

namespace UserProject.Presenters
{
    class UserTimeTablePresenter
    {
        private IUserTimeTableView view;
        private UserTimeTableRepository repo = new UserTimeTableRepository();

        public UserTimeTablePresenter(IUserTimeTableView param)
        {
            view = param;
        }

        public void getUserTimeTable() 
        {
            view.userTimeTableList = repo.getUserTimeTable();
        }

    }
}
