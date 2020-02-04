using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagerLibrary
{
    public class ReportItem
    {
       
        public string UserId { get; private set; }
        public string UserName { get; private set; }
        public string RightCode { get; private set; }

        public ReportItem(int userId, string userName, string rightCode)
        {
            UserId = Convert.ToString(userId);
            UserName = userName;
            RightCode = rightCode;
        }
    }
    
}
