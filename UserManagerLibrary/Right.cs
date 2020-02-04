using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagerLibrary
{
    public class Right
    {
        public int RightsID { get; private set; }
        public string RightsCode
        {
            get
            {
                if (RightsID == 0)
                {
                    return "READ_ONLY";
                }
                else if (RightsID == 1)
                {
                    return "APPROVE_REJECT";
                }
                else if (RightsID == 2)
                {
                    return "FULL_RIGHTS";
                } else
                {
                    return "RIGHTS_DENIED";
                }
            }
        }


        public Right(int rights_id)
        {
            if (rights_id >= 0 && rights_id <= 2)
            {
                RightsID = rights_id;
            }
            else
            {
                RightsID = 0;
            }
        }

    }
}
