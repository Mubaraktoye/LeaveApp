using Arch.EntityFrameworkCore.UnitOfWork;
using Leave_App.Model;
using Leave_App.Model.Data;
using LeeaveApp.Logic.Interface;
using System;
using System.Linq;


namespace LeeaveApp.Logic.Implementation
{
    public class LeaveBalanceLogic: ILeaveBalanceLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public LeaveBalanceLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public LeaveBalanceModel leaveBalance( string employeeId)
        {

            var getEmployee = _unitOfWork.GetRepository<LeaveRequest>().GetAll().Where(x => x.EmployeeId == employeeId).FirstOrDefault();

            var dateDifference= getEmployee.DateTo - DateTime.Today;
            var usedDays = DateTime.Today-getEmployee.DateFrom;
            

            return new LeaveBalanceModel
            {
                RemainingDays = dateDifference.Days,
                UsedDays = usedDays.Days,
                LeaveType=getEmployee.LeaveTypeId,
                EmployeeId=getEmployee.Id
            };
        }
    }
}
