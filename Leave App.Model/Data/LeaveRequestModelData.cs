using System;
using System.Collections.Generic;
using System.Text;

namespace Leave_App.Model
{
    public class LeaveRequestModelData
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public int NoOfDays { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime ResumptionDate { get; set; }
        public string Status { get; set; }
        public DateTime DateOfRequest { get; set; }
        public DateTime DateOfLastAction { get; set; }
    }
}
