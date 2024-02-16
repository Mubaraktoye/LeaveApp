using Leave_App.Model.Data;
using Leave_App.Model.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using static Leave_App.Model.Enum.LeaveStatus;

namespace Leave_App.Model
{
    public class LeaveRequest : BaseEntity
    {
        public string EmployeeId { get; set; }
        [MaxLength(5, ErrorMessage = "Enter a valid number")]
        [Range(1, 5)]
        public int LeaveTypeId { get; set; }
        [StringLength(25)]
        public int NoOfDays { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime ResumptionDate { get; set; }
        public LeaveStatus LeaveStatus { get; set; } //Received, Reviewing, Approved, Rejected, Expired, Completed
    }
}
