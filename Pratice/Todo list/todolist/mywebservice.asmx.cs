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
        public string SaveUserDetails(string name, string email)
        {
            return name + email;
        }

    }
}
