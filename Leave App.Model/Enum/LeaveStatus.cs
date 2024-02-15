using System;
using System.Collections.Generic;
using System.Text;

namespace Leave_App.Model.Enum
{
    public class LeaveStatus
    {
        public enum Status
        {
            Pending=1,
            Reviewing,
            Approved,
            Rejected,
            Completed
        }
    }
}
