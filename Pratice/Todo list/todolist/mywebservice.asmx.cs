using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace todolist
{
    [WebService(Namespace = "http://todolist.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

    public class mywebservice : System.Web.Services.WebService
    {

        [WebMethod]
        public string ProcessData(string name, string email)
        {
            try
            {
                // Your processing logic here

                return $"Received data: Name - {name}, Email - {email}";
            }
            catch (Exception ex)
            {
                // Log the exception for further analysis
                Console.WriteLine(ex.Message);
                throw; // Re-throw the exception to get more details in the browser console
            }
        }

    }
}
