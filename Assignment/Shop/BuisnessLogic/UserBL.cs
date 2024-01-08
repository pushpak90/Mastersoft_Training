using BuinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class UserBL
    {
        public int SaveUser(UserOB objob1)
        {
            UserDA da = new UserDA();
            return da.AddVendor(objob1);
        }
    }
}
