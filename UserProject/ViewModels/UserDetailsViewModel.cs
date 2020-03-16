using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProject.ViewModels
{
    public class UserDetailsViewModel
    {
        //userData
        public int userDataId { get; set; }
        public string userDataUser_name { get; set; }
        //personalData
        public int personalDataId { get; set; }
        public string personalDataFirst_name { get; set; }
        public string personalDataLast_name { get; set; }
        public string personalDataMother { get; set; }
        public System.DateTime personalDataBirth_date { get; set; }
        public string personalDataLocation { get; set; }
        public string personalDataEmail { get; set; }
        public string personalDataPhone { get; set; }
        public string personalDataPicture { get; set; }
        //position
        public int positionId { get; set; }
        public string positionPosition_name { get; set; }

        public UserDetailsViewModel(int userDataId, 
                                    string userDataUser_name, 
                                    int personalDataId, 
                                    string personalDataFirst_name, 
                                    string personalDataLast_name, 
                                    string personalDataMother, 
                                    DateTime personalDataBirth_date, 
                                    string personalDataLocation, 
                                    string personalDataEmail, 
                                    string personalDataPhone, 
                                    string personalDataPicture, 
                                    int positionId, 
                                    string positionPosition_name)
        {
            this.userDataId = userDataId;
            this.userDataUser_name = userDataUser_name;
            this.personalDataId = personalDataId;
            this.personalDataFirst_name = personalDataFirst_name;
            this.personalDataLast_name = personalDataLast_name;
            this.personalDataMother = personalDataMother;
            this.personalDataBirth_date = personalDataBirth_date;
            this.personalDataLocation = personalDataLocation;
            this.personalDataEmail = personalDataEmail;
            this.personalDataPhone = personalDataPhone;
            this.personalDataPicture = personalDataPicture;
            this.positionId = positionId;
            this.positionPosition_name = positionPosition_name;
        }

        

    }
}
