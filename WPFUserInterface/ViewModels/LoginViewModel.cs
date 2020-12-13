using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUserInterface.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;

        public string UserName
        {
            get { return _userName; }
            set 
            { 
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
            }
        }

        public string Password
        {
            get { return _password; }
            set 
            { 
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool CanLogIn 
        {
            get 
            {
                bool output = false;

                // ? after propterty test to see if it is null
                // If _property_ is not null THEN check the length
                if (UserName?.Length > 0 && Password?.Length > 0)
                {
                    output = true;
                }

                return output;
            }
        }

        public void LogIn ()
        {
            Console.WriteLine();
        }
    }
}
