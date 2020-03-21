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
        string errorUserName { get; set; }
        string errorFirstName { get; set; }
        string errorLastName { get; set; }
        string errorMother { get; set; }
        string errorPhone { get; set; }
        string errorLocation { get; set; }
        string errorPassword { get; set; }
    }
}
