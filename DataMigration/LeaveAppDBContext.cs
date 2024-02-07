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

        DbSet<EmployeeModelData> EmployeeMemberHistories { get; set; }
        DbSet<LeaveBalanceModelData> LeaveBalanceHistories { get; set; }
        DbSet<LeaveRequestModelData> LeaveRequestHistories { get; set; }
        DbSet<LeaveTypeModelData> LeaveTypeHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
