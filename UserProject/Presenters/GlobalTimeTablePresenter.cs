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
          
        GlobalTimeTableRepository repo = new GlobalTimeTableRepository();

        public GlobalTimeTablePresenter(IGlobalTimeTableView param)
        {
            view = param;
        }

        public void proba() 
        {
            view.userDataBindingList = repo.proba();
        }




    }
}
