using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProject.Models
{
    public partial class position
    {
        public position(string nev, int prio = 999, string desc = "", string perms = "")
        {
            this.user_data = new HashSet<user_data>();
            this.position_name = nev;
            this.priority = prio;
            this.description = desc;
            this.permission_ids = perms;            
        }

        public override string ToString()
        {
            return this.position_name;
        }
    }
}
