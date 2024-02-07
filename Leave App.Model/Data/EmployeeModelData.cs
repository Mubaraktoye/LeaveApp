using System;
using System.Collections.Generic;
using System.Text;

namespace Leave_App.Model
{
    /// <summary>
    /// employee detail
    /// </summary>
    public class EmployeeModelData
    {
            public int Id { get; set; }

            public int EmployeeId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int PhoneNumber { get; set; }
            public string Email { get; set; }
            
    }
}
