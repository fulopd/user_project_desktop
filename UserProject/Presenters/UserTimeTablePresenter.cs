﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;
using UserProject.Repositories;
using UserProject.Services;
using UserProject.ViewInterfaces;

namespace UserProject.Presenters
{
    class UserTimeTablePresenter
    {
        private IUserTimeTableView view;        

        public UserTimeTablePresenter(IUserTimeTableView param)
        {
            view = param;
        }

        public void GetUserTimeTable() 
        {            
            view.userTimeTableList = CurrentUser.user.time_table.ToList();
        }

    }
}