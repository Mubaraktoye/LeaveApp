using Arch.EntityFrameworkCore.UnitOfWork;
using Leave_App.Model;
using Leave_App.Model.Data;
using LeeaveApp.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeeaveApp.Logic.Implementation
{
    public class LeaveBalanceLogic: ILeaveBalanceLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public LeaveBalanceLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public LeaveBalanceModel leaveBalance( int employeeId)
        {

            var getEmployee = _unitOfWork.GetRepository<LeaveRequestModelData>().GetAll().Where(x => x.EmployeeId == employeeId).FirstOrDefault();

            var dateDifference= getEmployee.DateTo-getEmployee.DateFrom;

            return new LeaveBalanceModel
            {
                RemainingDays = dateDifference.Days.ToString("d"),
            };
        }
    }
}
