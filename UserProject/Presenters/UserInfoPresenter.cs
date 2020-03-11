using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Services;
using UserProject.ViewInterfaces;

namespace UserProject.Presenters
{
    class UserInfoPresenter
    {
        IUserInfoView view;

        public UserInfoPresenter(IUserInfoView param)
        {
            view = param;
        }

        public void GetUserData() 
        {
            view.firstName = CurrentUser.user.personal_data.first_name;
            view.lastName = CurrentUser.user.personal_data.last_name;
            view.motherName = CurrentUser.user.personal_data.mother;
            view.birthDate = CurrentUser.user.personal_data.birth_date;
            view.location = CurrentUser.user.personal_data.location;
            view.email = CurrentUser.user.personal_data.email;
            view.phone = CurrentUser.user.personal_data.phone;
            view.userName = CurrentUser.user.user_name;
            view.position = CurrentUser.user.position.position_name;
            view.firstWorkDay = (DateTime)CurrentUser.user.first_working_day;
            
        }
    }
}
