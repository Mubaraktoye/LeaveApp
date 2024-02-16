using Leave_App.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Leave_App.Model
{
    /// <summary>
    /// Leave balance detail
    /// </summary>
    public class LeaveBalance: BaseEntity
    {
        [StringLength(25)]
        public int LeaveTypeId { get; set; }
        [StringLength(25)]
        public string EmployeeId { get; set; } //EmployeeId on Employee data is int (assuming they are meant to be same property)
        [StringLength(25)]
        public int UsedDays { get; set; }
        [StringLength(25)]
        public string RemainingDays { get; set; }
        [StringLength(25)]
        public int Year {  get; set; }
       

    }
}
