using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagerLibrary
{
    public class User
    {
        public int UserID { get; private set; }
        public string UserName { get; set; }

        private Right UserRight;

        public User(int userid, string userName, Right userRight)
        {
            UserID = userid;
            UserName = userName;
            UserRight = userRight;
        }

        public void ChangeUserRights(Right changeRights)
        {
            UserRight = changeRights;
        }

        public string GetUserRights()
        {
            return UserRight.RightsCode;
        }
    }
}
