using Arch.EntityFrameworkCore.UnitOfWork;
using Leave_App.Model;
using Leave_App.Model.Data;
using LeeaveApp.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeeaveApp.Logic.Implementation
{
    public class LeaveTypeLogic: IleaveTypelogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public LeaveTypeLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public string AddLeaveType (LeaveTypeModel model)
        {
            var newLeaveType = new LeaveType
            {
                Name = model.NameOfLeave,
                Description = model.Description,
                NoOfDays = model.NoOfDays,
            };
            _unitOfWork.GetRepository<LeaveType>().Insert(newLeaveType);
            _unitOfWork.SaveChanges();
            return $"You have sucessfully added a new leave type";
        }
    }
}
