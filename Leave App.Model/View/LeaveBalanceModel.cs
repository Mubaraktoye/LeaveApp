using System;
using System.Collections.Generic;
using System.Text;

namespace Leave_App.Model.Data
{
    public class LeaveBalanceModel
    {
        public int id { get; set; }
        public string EmployeeId { get; set; }
        public int UsedDays { get; set; }
        public string RemainingDays { get; set; }
        public string LeaveType { get; set; }

    }
}
