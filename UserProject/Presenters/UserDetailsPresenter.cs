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
    class UserDetailsPresenter
    {
        IUserDetailsView view;                        

        public UserDetailsPresenter(IUserDetailsView param)
        {
            view = param;
        }

        public void GetAllPositions()
        {
            using (var positionRepo = new PositionsRepository())
            {
                view.positionList = positionRepo.getAllPositions();
            }
            
        }

        public void GetUserData(int userDataId) 
        {
            using (UserDataRepository userRepo = new UserDataRepository())
            {
                view.user = userRepo.GetUserData(userDataId);
            }
            
        }

        public void GetPersonalData(int personalDataId)
        {
            using (PersonalDataRepository personalRepo = new PersonalDataRepository())
            {
                view.personal = personalRepo.GetPersonalData(personalDataId);
            }
            
        }

        public void UpdatePictur(int id, string fileName)
        {
            using (PersonalDataRepository personalRepo = new PersonalDataRepository())
            {
                personalRepo.UpdatePicture(id, fileName);
            }
        }

        public int SavePersonalData(personal_data personalParam)
        {
            int id;
            using (PersonalDataRepository personalRepo = new PersonalDataRepository())
            {
                if (personalRepo.Exists(personalParam))
                {
                    try
                    {
                        personalRepo.Update(personalParam);
                        personalRepo.Save();
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
                        Debug.WriteLine("userPresenter: personal data insert kész");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
                id = personalRepo.GetPersonalDataId(personalParam);
            }
            return id;

        }

        public void SaveUserData(user_data userParam,int personnalId)
        {
            using (UserDataRepository userRepo = new UserDataRepository())
            {
                if (userRepo.Exists(userParam))
                {
                    try
                    {
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
                        userParam.personal_data_id = personnalId;
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
}
