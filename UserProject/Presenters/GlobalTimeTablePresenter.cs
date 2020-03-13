using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;
using UserProject.Repositories;
using UserProject.ViewInterfaces;

namespace UserProject.Presenters
{
    class GlobalTimeTablePresenter
    {
        IGlobalTimeTableView view;
          
        TimeTableRepository repo = new TimeTableRepository();

        public GlobalTimeTablePresenter(IGlobalTimeTableView param)
        {
            view = param;
        }

        public void GetAllData() 
        {
            view.userDataList = repo.proba();
        }




    }
}
