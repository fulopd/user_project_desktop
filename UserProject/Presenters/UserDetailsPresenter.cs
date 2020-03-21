using System;
using System.Diagnostics;
using UserProject.Models;
using UserProject.Properties;
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

        public bool validateData(personal_data personalParam, user_data user)
        {
            view.errorFirstName = null;
            view.errorLastName = null;
            view.errorMother = null;
            view.errorPhone = null;
            view.errorLocation = null;

            view.errorUserName = null;
            view.errorPassword = null;

            bool valid = true;
            if (string.IsNullOrEmpty(personalParam.first_name))
            {
                view.errorFirstName = Resources.errorRequired;
                valid = false;
            }
            if (string.IsNullOrEmpty(personalParam.last_name))
            {
                view.errorLastName = Resources.errorRequired;
                valid = false;
            }
            if (string.IsNullOrEmpty(personalParam.mother))
            {
                view.errorMother = Resources.errorRequired;
                valid = false;
            }
            if (string.IsNullOrEmpty(personalParam.phone))
            {
                view.errorPhone = Resources.errorRequired;
                valid = false;
            }
            if (string.IsNullOrEmpty(personalParam.location))
            {
                view.errorLocation = Resources.errorRequired;
                valid = false;
            }



            if (string.IsNullOrEmpty(user.user_name))
            {
                view.errorUserName = Resources.errorRequired;
                valid = false;
            }
            else
            {
                using (UserDataRepository userRepo = new UserDataRepository())
                {
                    if (user.id>0)//Már létező user
                    {
                        var oldUser = userRepo.GetUserData(user.id);
                        if (oldUser.user_name != user.user_name)//csak akkor kell ellenőrizni ha történt változás a userName ben
                        {
                            if (userRepo.UserNameExist(user.user_name))
                            {
                                view.errorUserName = Resources.errorExist;
                                valid = false;
                            }
                        }
                    }
                    else// Új user
                    {
                        if (userRepo.UserNameExist(user.user_name))
                        {
                            view.errorUserName = Resources.errorExist;
                            valid = false;
                        }
                    }
                    
                }
            }
            if (string.IsNullOrEmpty(user.password))
            {
                view.errorPassword = Resources.errorRequired;
                valid = false;
            }

            return valid;
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


        public void SaveUserData(user_data userParam, int personnalId)
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
