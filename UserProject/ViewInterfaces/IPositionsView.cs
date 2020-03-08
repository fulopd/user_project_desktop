using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;

namespace UserProject.ViewInterfaces
{
    interface IPositionsView
    {       
        List<position> statPositionList { get; set; }
        string descriptions { get; }
        List<permission> availablePermissionsList { set; }
        List<permission> positionPermissionsList { set; }
    }
}
