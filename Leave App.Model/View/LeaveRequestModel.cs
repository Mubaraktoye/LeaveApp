using System;
using System.Collections.Generic;
using System.Text;

namespace Leave_App.Model.Data
{
    public class LeaveRequestModel
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public int NoOfDays { get; set; }
        public DateTime DateFrom { get; set; }
      
        
    }
}
