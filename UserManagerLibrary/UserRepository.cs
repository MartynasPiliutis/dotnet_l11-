using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagerLibrary
{
    public class UserRepository
    {
        private List<User> UsersList;

        public UserRepository()
        {
            UsersList = new List<User>();
            UsersList.Add(new User(501, "VardasPavarde1", new Right(0)));
            UsersList.Add(new User(010, "VardasPavarde2", new Right(2)));
            UsersList.Add(new User(011, "VardasPavarde3", new Right(1)));
            UsersList.Add(new User(712, "VardasPavarde4", new Right(1)));
            UsersList.Add(new User(113, "VardasPavarde5", new Right(2)));
            UsersList.Add(new User(014, "VardasPavarde6", new Right(0)));
            UsersList.Add(new User(515, "VardasPavarde7", new Right(0)));
            UsersList.Add(new User(016, "VardasPavarde8", new Right(2)));
            UsersList.Add(new User(017, "VardasPavarde9", new Right(0)));
            UsersList.Add(new User(102, "VardasPavarde0", new Right(1)));
        }

        public User GetUserByID(int findID)
        {
            foreach (var user in UsersList)
            {
                if (findID == user.UserID)
                {
                    return user;
                }
            }
            return null;
        }

        public List<User> GetUsersList()
        {
            return UsersList;
        }

        public void AddNewUser(int newUserId, string newUserName, int newUserRight)
        {
            User newUserCheck = GetUserByID(newUserId);
            if (newUserCheck == null)
            {
                UsersList.Add(new User(newUserId, newUserName, new Right(newUserRight)));
            }
            else return;
        }

        public void DeleteUserByID(int deleteUserId)
        {
            User deleteUserCheck = GetUserByID(deleteUserId);
            if (deleteUserCheck != null)
            {
                for (int i = 0; i < UsersList.Count; i++)
                {
                    if (deleteUserId == UsersList[i].UserID)
                    {
                        UsersList.RemoveAt(i);
                        return;
                    }
                }
            }
        }

    }
}
