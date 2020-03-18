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
        private static string host;
        
        public static void upload(string localFileFullPath, string destFileName) 
        {
            using (var client = new WebClient())
            {                
                client.Credentials = new NetworkCredential("test", "test");                
                client.UploadFile("ftp://localhost/user_project_web/Images/"+ destFileName,
                                    WebRequestMethods.Ftp.UploadFile,
                                    localFileFullPath);                
            }
        }

    }
}
