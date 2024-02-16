using Leave_App.Model.Data;

using System.ComponentModel.DataAnnotations;


namespace Leave_App.Model
{
    /// <summary>
    /// employee detail
    /// </summary>
    public class Employee : BaseEntity
    {
        //With no property validation model is susceptible to database attack
        //i.e [StringLenght(25)] on FirstName and LastName etc.
        public string EmployeeId { get; set; }
        [StringLength(25)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        [StringLength(25)]
        public string? PhoneNumber { get; set; } //Any property with no calaculation effect should be string
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
            
    }
}
