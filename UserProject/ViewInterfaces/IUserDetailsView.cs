using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;
using UserProject.ViewModels;

namespace UserProject.ViewInterfaces
{
    interface IUserDetailsView
    {
        UserDetailsViewModel udvm { get; set; }
        personal_data personal { get; set; }
        user_data user { get; set; }
        BindingList<position> positionList { get; set; }
    }
}
