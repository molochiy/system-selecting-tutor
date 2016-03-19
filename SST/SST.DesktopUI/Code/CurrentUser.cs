using SST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.DesktopUI.Code
{
    public static class CurrentUser
    {
        private static User _currentUser;

        public static void Initialize(User user)
        {
            if(_currentUser != null)
            {
                throw new InvalidOperationException("Current user has already been specified");
            }
            _currentUser = user;
        }

        public static int Id
        {
            get
            {
                return _currentUser.Id;
            }
        }

        public static string FirstName
        {
            get
            {
                return _currentUser.FirstName;
            }
        }

        public static string LastName
        {
            get
            {
                return _currentUser.LastName;
            }
        }

        public static string Login
        {
            get
            {
                return _currentUser.Login;
            }
        }
    }
}
