using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProject.ViewInterfaces
{
    interface IUserInfoView
    {
        string firstName { set; }
        string lastName { set; }
        string motherName { set; }
        DateTime birthDate { set; }
        string location { set; }
        string email { set; }
        string phone { set; }
        string userName { set; }
        string position { set; }
        DateTime firstWorkDay { set; }


    }
}
