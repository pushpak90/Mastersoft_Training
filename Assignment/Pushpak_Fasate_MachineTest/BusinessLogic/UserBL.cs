using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UserBL
    {
        public string login_da(UserBO ob)
        {
            UserDA da = new UserDA();
            return da.login(ob);
        }

        public object ddldeg_da()
        {
            UserDA da = new UserDA();
            return da.ddldeg();
        }

        public object ddlbranch_da(UserBO ob)
        {
            UserDA da = new UserDA();
            return da.ddlbranch(ob);
        }

        public string insert_stu(UserBO ob)
        {
            UserDA da = new UserDA();
            return da.stu_sub(ob);
        }

        public object grid_da()
        {
            UserDA da = new UserDA();
            return da.show_grid();
        }

        public object delete_rec(UserBO ob)
        {
            UserDA da = new UserDA();
            return da.del_rec(ob);
        }

        public string update_rec_da(UserBO ob)
        {
            UserDA da = new UserDA();
            return da.update_rec(ob);   
        }
    }
}
