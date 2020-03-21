using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;
using UserProject.Properties;
using UserProject.Repositories;
using UserProject.ViewInterfaces;

namespace UserProject.Presenters
{
    public class PositionAddPresenter
    {
        IPositionAddView view;
        
        public PositionAddPresenter(IPositionAddView param)
        {
            view = param;
        }

        public void ErroCheck(position poz) 
        {
            view.errorMessage = null;

            if (string.IsNullOrWhiteSpace(poz.position_name))
            {
                view.errorMessage = Resources.errorRequired;
            }

            using (PositionsRepository pozRepo= new PositionsRepository())
            {
                if (pozRepo.Exist(poz))
                {
                    view.errorMessage = Resources.errorExist;
                }
            }

            
        }
    }
}
