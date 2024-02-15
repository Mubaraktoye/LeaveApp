using System;
using System.Collections.Generic;
using System.Text;

namespace Leave_App.Model.Data
{
    public class LeaveBalanceModel
    {
        public int id { get; set; }

        public int EmployeeId { get; set; }
        public int UsedDays { get; set; }
        public int RemainingDays { get; set; }
        public int LeaveType { get; set; }

    }
}
