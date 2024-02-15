using System;
using System.Collections.Generic;
using System.Text;

namespace Leave_App.Model.Data
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
