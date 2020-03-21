using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UserProject.Services
{
    public static class FTP
    {
        public static string host = "ftp://localhost/user_project_web/";
        public static string user = "test";
        public static string pass = "test";


        //TODO: Adatok bekérése, kapcsolat ellenőrzése
        public static void upload(string localFileFullPath, string destFileName) 
        {
            using (var client = new WebClient())
            {                
                client.Credentials = new NetworkCredential(user, pass);                
                client.UploadFile(host + "Images/"+ destFileName,
                                    WebRequestMethods.Ftp.UploadFile,
                                    localFileFullPath);                
            }
        }

    }
}
