using System;
using System.Collections.Generic;
using System.Text;

namespace Leave_App.Model.Data
{
    public class LeaveTypeModel
    {
        public int id { get; set; }
        public string NameOfLeave { get; set; }
        public string Description { get; set; }
        public int NoOfDays { get; set; }

    }
}
