using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Leave_App.Model.Data
{
    public class LeaveTypeModel
    {
        public int id { get; set; }
        [StringLength(25)]
        public string NameOfLeave { get; set; }
        [StringLength(25)]
        public string Description { get; set; }
        [StringLength(25)]
        public int NoOfDays { get; set; }

    }
}
