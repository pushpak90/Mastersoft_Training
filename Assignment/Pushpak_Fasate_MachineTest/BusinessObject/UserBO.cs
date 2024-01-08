using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class UserBO
    {
        private int _Id;
        private string _Username;
        private string _Password;

        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        public string Username
        {
            get
            {
                return _Username;
            }
            set
            {
                _Username = value;
            }
        }
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }

        private string _Sel_deg;
        public string Sel_deg
        {
            get
            {
                return _Sel_deg;
            }
            set
            {
                _Sel_deg = value;
            }
        }

        private string _sName;
        private string _DOB;
        private string _Gender;
        private string _Degree;
        private string _Branch;
        private string _Email;
        private string _Mobile;
        private string _Upload;
        private string _Check;

        public string sName
        {
            get
            {
                return _sName;
            }
            set
            {
                _sName = value;
            }
        }

        public string DOB
        {
            get
            {
                return _DOB; 
            }
            set
            {
                _DOB = value;
            }
        }

        public string Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
            }
        }

        public string Degree
        {
            get
            {
                return _Degree;
            }
            set
            {
                _Degree = value;
            }
        }

        public string Branch
        {
            get
            {
               return _Branch;
            }
            set
            {
                _Branch = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        public string Mobile
        {
            get
            {
                return _Mobile;
            }
            set
            {
                _Mobile = value;
            }
        }

        public string Upload
        {
            get
            {
                return _Upload;
            }
            set
            {
                _Upload = value;
            }
        }

        public string Check
        {
            get
            {
                 return _Check;
            }
            set
            {
                _Check = value;
            }
        }

    }
}
