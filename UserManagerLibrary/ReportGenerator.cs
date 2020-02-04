using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagerLibrary
{
    public class ReportGenerator
    {
        private List<User> UsersList;

        public ReportGenerator(List<User> userList)
        {
            UsersList = userList;
        }

        public List<ReportItem> GenerateAllUsersList()
        {
            List<ReportItem> userReport = new List<ReportItem>();
            foreach (var user in UsersList)
            {
                ReportItem oneItem = new ReportItem(user.UserID, user.UserName, user.GetUserRightsCode());
                userReport.Add(oneItem);
            }
            return userReport;
        }

        public List<ReportItem> GenerateUsersListByRightCode(int RightCode)
        {
            List<ReportItem> userReportByRightCode = new List<ReportItem>();
            foreach (var user in UsersList)
            {
                int userRightCode = user.GetUserRightsID();
                if (userRightCode == RightCode)
                {
                    ReportItem oneItem = new ReportItem(user.UserID, user.UserName, user.GetUserRightsCode());
                    userReportByRightCode.Add(oneItem);
                }
                
            }
            return userReportByRightCode;
        }
    }
}
