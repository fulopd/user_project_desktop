using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProject.Models
{
    public partial class user_data
    {
        public user_data(string user_name, string password, DateTime? first_working_day, DateTime? last_working_day, int position_id)
        {
            this.user_name = user_name;
            this.password = password;
            this.first_working_day = first_working_day;
            this.last_working_day = last_working_day;
            this.position_id = position_id;
        }
    }
}
