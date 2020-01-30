using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagerLibrary
{
    public class Users
    {
        public int UserID { get; private set; }
        public string UserName { get; set; }

        private Rights UserRight;

        public Users(int _userid, string _userName, Rights _userRight)
        {
            UserID = _userid;
            UserName = _userName;
            UserRight = _userRight;
        }

        public void ChangeUserRights(Rights _changeRights)
        {
            UserRight = _changeRights;
        }

        public string GetUserRights()
        {
            return UserRight.RightsCode;
        }
    }
}
