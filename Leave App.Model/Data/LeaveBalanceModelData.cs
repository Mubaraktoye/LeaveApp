using System;
using System.Collections.Generic;
using System.Text;

namespace Leave_App.Model
{
    /// <summary>
    /// Leave balance detail
    /// </summary>
    public class LeaveBalanceModelData
    {
        public int id {  get; set; }
        public string EmployeeId { get; set; }
        public int UsedDays { get; set; }
        public string RemainingDays { get; set; }
        public string LeaveType { get; set; }

    }
}
