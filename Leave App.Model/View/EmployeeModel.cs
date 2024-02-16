using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Leave_App.Model.View
{
    public class EmployeeModel
    {
        public string EmployeeId { get; set; }
        [StringLength(25)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        [StringLength(25)]
        public string PhoneNumber { get; set; }
        [StringLength(25)]
        [EmailAddress]
        public string Email { get; set; }

    }
}
