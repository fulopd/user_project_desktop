using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;
using UserProject.Services;

namespace UserProject.Repositories
{
    class UserTimeTableRepository
    {
        private userProjectDBContext db = new userProjectDBContext();

        public List<time_table> getUserTimeTable() 
        {
            IQueryable<time_table> quary = db.time_table.Where(x => x.user_id == CurrentUser.id);

            return new List<time_table>(quary.ToList());
        }
    }
}
