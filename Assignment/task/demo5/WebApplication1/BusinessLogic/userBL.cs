using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess;

namespace BusinessLogic
{
    public class userBL
    {
        public string insertdata(userBO bo)
        {
            userDA da = new userDA();
            return da.inputdata(bo);
        }

        public object bl_ddl_dept()
        {
            userDA da = new userDA();
            return da.show_dd();
        }

        public object bl_list_show() 
        {
            userDA da = new userDA();
            return da.show_list();
        }

        public string bl_text_fetch(userBO bo)
        {
            userDA da = new userDA();
            return da.fetch_data(bo);
        }
    }
}
