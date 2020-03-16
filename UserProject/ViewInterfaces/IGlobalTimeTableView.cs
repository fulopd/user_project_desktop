using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;

namespace UserProject.ViewInterfaces
{
    public interface IGlobalTimeTableView
    {        
        DataTable globalTimeTable { get; set; }
        DateTime selectedDate { get; }
    }
}
