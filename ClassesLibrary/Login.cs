using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        //frugal / fields
        private string _username;
        private string _password;

        //people / properties
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        public string PassWord
        {
            get { return _password; }
            set { _password = value; }
        }

        //collect / constructors (ctors)
        public Login(string userName, string passWord)
        {
            UserName = userName;
            PassWord = passWord;
        }

        //money / methods
        public Login() { }
        public override string ToString()
        {
            return string.Format("Username is: {0}\n" +
                                 "Password is: {1}\n",
                                 UserName,
                                 PassWord);
        }//end ToString()
    }
}
