using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProject.Models
{
    public partial class time_table
    {
        public time_table(int user_id, DateTime start_date, DateTime? end_date, bool? paid_leave, bool? sick_leave)
        {
            this.user_id = user_id;
            this.start_date = start_date;
            this.end_date = end_date;
            this.paid_leave = paid_leave;
            this.sick_leave = sick_leave;
        }

        public time_table()
        {

        }
    }
}
