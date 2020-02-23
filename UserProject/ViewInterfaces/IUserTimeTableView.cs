using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;

namespace UserProject.ViewInterfaces
{
    interface IUserTimeTableView
    {
        List<time_table> userTimeTableList { set; }
    }
}
