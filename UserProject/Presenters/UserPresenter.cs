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

        public void LoadData()
        {
            using (var positionRepo = new PositionsRepository())
            {
                view.positionList = positionRepo.getAllPositions();
            }
        }

        public void SavePersonalDataAndUserData(personal_data personalParam, user_data userParam)
        {            
            if (personalRepo.Exists(personalParam) && userRepo.Exists(userParam))
            {                
                try
                {                   
                    personalRepo.Update(personalParam);
                    personalRepo.Save();
                   
                    userRepo.Update(userParam);                                       
                    userRepo.Save();                    
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
                    personalRepo.Insert(personalParam);
                    personalRepo.Save();
                    userParam.personal_data_id = personalRepo.GetPersonalDataId(personalParam);
                    userRepo.Insert(userParam);
                    userRepo.Save();
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
