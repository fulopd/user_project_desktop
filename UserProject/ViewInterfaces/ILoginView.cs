using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProject.ViewInterfaces
{
    interface ILoginView
    {
        string userName { get; }
        string password { get; }
        string errorMessage { set; }
    }
}
