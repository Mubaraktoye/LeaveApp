using System;
using System.Collections.Generic;
using System.Text;

namespace Leave_App.Model
{
    public class LeaveTypeModelData
    {
        public int id { get; set; }
        public string NameOfLeave { get; set; }
        public string Description { get; set; }
        public int NoOfDays { get; set; }

    }
}
