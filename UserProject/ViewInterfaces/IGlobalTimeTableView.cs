using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;

namespace UserProject.ViewInterfaces
{
    public interface IGlobalTimeTableView
    {
        BindingList<user_data> userDataBindingList { get; set; }
    }
}
