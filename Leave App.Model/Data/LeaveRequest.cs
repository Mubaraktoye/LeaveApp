using Leave_App.Model.Data;
using System;
using static Leave_App.Model.Enum.LeaveStatus;

namespace Leave_App.Model
{
    public class LeaveRequest : BaseEntity
    {
        public string EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public int NoOfDays { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime ResumptionDate { get; set; }
        public Status Status { get; set; } //Received, Reviewing, Approved, Rejected, Expired, Completed
    }
}
