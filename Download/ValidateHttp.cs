using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Download
{
    internal class ValidateHttp
    {
        internal static bool IsUrl(string url) 

        {  

            try
            {
                //Creating the HttpWebRequest
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //Setting the Request method HEAD, you can also use GET too.
                //request.Timeout = 5000;
                request.Method = "HEAD";
                //Getting the Web Response.
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Returns TURE if the Status code == 200
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch(Exception e)
            {
                string err =(e.Message);
                return false;
            }
         }
        internal static bool IsUrl(string url,bool http)
        {

            //try
            //{
            //    Creating the HttpWebRequest
            //    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            //    Setting the Request method HEAD, you can also use GET too.
            //    request.Method = "GET";
            //    Getting the Web Response.
            //    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //    Returns TURE if the Status code == 200
            //    return (response.StatusCode == HttpStatusCode.OK);
            //}
            //catch (Exception e)
            //{
            //    string err = (e.Message);
            //    return false;
            //}
            return Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute);
            //return true;
        }
        internal static string GetDownloadFolder()
        {
            String userRoot = System.Environment.GetEnvironmentVariable("USERPROFILE");
            return Path.Combine(userRoot, "Downloads");
        }
    }
   
}
