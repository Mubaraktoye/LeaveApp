using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Leave_App.Model.Data
{
    public class LeaveBalanceModel
    {
        public int id { get; set; }

        public int EmployeeId { get; set; }
        [StringLength(25)]
        public int UsedDays { get; set; }
        [StringLength(25)]
        public int RemainingDays { get; set; }
        [StringLength(25)]
        public int LeaveType { get; set; }

    }
}
