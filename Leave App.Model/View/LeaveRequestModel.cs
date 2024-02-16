using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Leave_App.Model.Data
{
    public class LeaveRequestModel
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        [StringLength(25)]
        public int LeaveTypeId { get; set; }
        [StringLength(25)]
        public int NoOfDays { get; set; }
        [StringLength(25)]
        public DateTime DateFrom { get; set; }
      
        
    }
}
