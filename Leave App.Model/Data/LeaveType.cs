using Leave_App.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Leave_App.Model
{
    public class LeaveType: BaseEntity
    {
        public string Name { get; set; }
        [StringLength(25)]
        public string Description { get; set; }
        [StringLength(25)]
        public int NoOfDays { get; set; }

    }
}
