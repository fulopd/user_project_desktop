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

        private bool ConnectionExist() 
        {
            return db.Database.Exists();
        }

        public void CheckConnection()
        {
            if (!ConnectionExist())
            {
                view.errorMessage = "Adatbázishoz való kapcsolódás sikertelen";
            }
        }

        public void Authenticate() 
        {
            if (!ConnectionExist())
            {
                view.errorMessage = "Adatbázishoz való kapcsolódás sikertelen";
            }
            else
            {
                DateTime date = DateTime.Now;
                
                var user = db.user_data.SingleOrDefault(x => 
                        x.user_name == view.userName && 
                        x.password == view.password && 
                        (x.last_working_day == null || x.last_working_day >= date.Date));

                if (user != null)
                {
                    string[] sPermissonons = user.position.permission_ids.Split(',');
                    int[] perm = Array.ConvertAll(sPermissonons, s => int.Parse(s));
                    if (perm.Contains(6))
                    {
                        loginSucces = true;
                        CurrentUser.user = user;
                        CurrentUser.id = user.id;
                    }
                    else
                    {
                        view.errorMessage = "Nem megfelelő jogosultsági szint!";
                    }
                                 
                }
                else
                {
                    view.errorMessage = "Hibás felhasználónév vagy jelszó!";
                }
            }
        }
    }
}
