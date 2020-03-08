using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;
using UserProject.ViewInterfaces;

namespace UserProject.Presenters
{
    public class PositionAddPresenter
    {
        IPositionAddView view;
        private userProjectDBContext db = new userProjectDBContext();

        public PositionAddPresenter(IPositionAddView param)
        {
            view = param;
        }

        public void erroCheck(position poz) 
        {
            view.errorMessage = null;
            if (db.position.Any(x => x.position_name == poz.position_name))
            {
                view.errorMessage = "Pozició már létezik";
            }
        }
    }
}
