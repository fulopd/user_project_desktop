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
    class UserPresenter
    {
        IUserView view;
        private static userProjectDBContext db = new userProjectDBContext();
        PersonalDataRepository personalRepo = new PersonalDataRepository(db);
        UserDataRepository userRepo = new UserDataRepository(db);

        public UserPresenter(IUserView param)
        {
            view = param;
        }

        public void loadData()
        {
            using (var positionRepo = new PositionsRepository())
            {
                view.positionList = positionRepo.getAllPositions();
            }
        }

        public void savePersonalDataAndUserData(personal_data personalParam, user_data userParam)
        {            
            if (personalRepo.exists(personalParam) && userRepo.exists(userParam))
            {                
                try
                {                   
                    personalRepo.update(personalParam);
                    personalRepo.save();
                   
                    userRepo.update(userParam);                                       
                    userRepo.save();                    
                }   
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            else
            {
                try
                {
                    personalRepo.insert(personalParam);
                    personalRepo.save();
                    userParam.personal_data_id = personalRepo.getId(personalParam);
                    userRepo.insert(userParam);
                    userRepo.save();
                    Debug.WriteLine("userPresenter: insert kész");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }            
        }


    }
}
