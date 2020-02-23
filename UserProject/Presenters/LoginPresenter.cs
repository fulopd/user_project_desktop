using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;
using UserProject.Services;
using UserProject.ViewInterfaces;

namespace UserProject.Presenters
{
    class LoginPresenter
    {
        private ILoginView view;
        private userProjectDBContext db = new userProjectDBContext();
        public bool loginSucces;

        public LoginPresenter(ILoginView param)
        {
            view = param;
        }

        private bool connectionExist() 
        {
            return db.Database.Exists();
        }

        public void checkConnection()
        {
            if (!connectionExist())
            {
                view.errorMessage = "Adatbázishoz való kapcsolódás sikertelen";
            }
        }

        public void authenticate() 
        {
            if (!connectionExist())
            {
                view.errorMessage = "Adatbázishoz való kapcsolódás sikertelen";
            }
            else
            {
                var user = db.user_data.SingleOrDefault(x => x.user_name == view.userName && x.password == view.password);

                if (user != null)
                {
                    loginSucces = true;
                    CurrentUser.user = user;
                    CurrentUser.id = user.id;                    
                }
                else
                {
                    view.errorMessage = "Hibás felhasználónév vagy jelszó!";
                }
            }
        }
    }
}
