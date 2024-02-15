using Leave_App.Model.Data;

namespace Leave_App.Model
{
    /// <summary>
    /// Leave balance detail
    /// </summary>
    public class LeaveBalance: BaseEntity
    {
        public int LeaveTypeId { get; set; }
        public string EmployeeId { get; set; } //EmployeeId on Employee data is int (assuming they are meant to be same property)
        public int UsedDays { get; set; }
        public string RemainingDays { get; set; }
       

    }
}
