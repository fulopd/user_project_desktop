using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;

namespace UserProject.ViewInterfaces
{
    public interface IPositionAddView
    {
        position newPosition { get; set; }
        string errorMessage { get; set; }
    }
}
