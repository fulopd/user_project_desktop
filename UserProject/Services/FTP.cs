using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UserProject.Services
{
    public static class FTP
    {
        public static string host = "localhost";
        public static string path = "user_project_web/Images/";
        public static string user = "test";
        public static string pass = "test";

        public static void upload(string localFileFullPath, string destFileName)
        {
            using (var client = new WebClient())
            {
                client.Credentials = new NetworkCredential(user, pass);
                client.UploadFile("ftp://" + host + "/" + path + destFileName,
                                    WebRequestMethods.Ftp.UploadFile,
                                    localFileFullPath);
            }
        }

        public static void FTPConfig()
        {
            if (File.Exists("FTPConfig.txt"))
            {
                using (StreamReader sr = new StreamReader("FTPConfig.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split('=');
                        switch (line[0])
                        {
                            case "host":
                                host = line[1];
                                break;
                            case "path":
                                path = line[1];
                                break;
                            case "user":
                                user = line[1];
                                break;
                            case "pass":
                                pass = line[1];
                                break;
                            default:
                                break;
                        }
                    }
                    Debug.WriteLine("Host: " + host +" Path: "+ path +" UserName: " + user + " Password: " + pass);
                }
            }
            else
            {
                Debug.WriteLine("File nem elérhető");
            }

        }

    }
}
