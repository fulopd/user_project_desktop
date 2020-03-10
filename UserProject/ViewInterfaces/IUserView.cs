using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;

namespace UserProject.ViewInterfaces
{
    public interface IUserView
    {
        personal_data personal { get; set; }
        user_data user { get; }
        BindingList<position> positionList { get; set; }

    }
}
