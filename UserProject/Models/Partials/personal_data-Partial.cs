using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProject.Models
{
    public partial class personal_data
    {       

        public personal_data(
            string first_name, 
            string last_name, 
            string mother, 
            DateTime birth_date, 
            string location, 
            string email, 
            string phone, 
            string picture)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.mother = mother;
            this.birth_date = birth_date;
            this.location = location;
            this.email = email;
            this.phone = phone;
            this.picture = picture;          
        }
                
    }
}
