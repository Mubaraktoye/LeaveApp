using Leave_App.Model.Data;

namespace Leave_App.Model
{
    public class LeaveType: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NoOfDays { get; set; }

    }
}
