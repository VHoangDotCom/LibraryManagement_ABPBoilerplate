using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Constants.Enum
{
    public class UserEnums
    {
        public enum UserType
        {
            Internship = 0,
            Collaborators = 1,
            Staff = 2,
            ProbationaryStaff = 3,
            FakeUser = 4,
            Vendor = 5
        }
        public enum Job
        {
            DEV = 0,
            TESTER = 1,
            BACK_OFFICE = 2,
            CORE = 3,
            SIPDO = 4,
            RENHONG = 5
        }
    }
}
