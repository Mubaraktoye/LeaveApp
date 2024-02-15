using Leave_App.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataMigration
{
    public class LeaveAppDBContext: DbContext
    {
        public LeaveAppDBContext(DbContextOptions<LeaveAppDBContext> options) : base(options) { }

        DbSet<Employee> EmployeeMemberHistories { get; set; }
        DbSet<LeaveBalance> LeaveBalanceHistories { get; set; }
        DbSet<LeaveRequest> LeaveRequestHistories { get; set; }
        DbSet<LeaveType> LeaveTypeHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
