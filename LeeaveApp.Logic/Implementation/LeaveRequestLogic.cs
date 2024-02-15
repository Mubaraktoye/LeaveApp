using Arch.EntityFrameworkCore.UnitOfWork;
using Leave_App.Model;
using Leave_App.Model.Data;
using LeeaveApp.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace LeeaveApp.Logic.Implementation
{
    public class LeaveRequestLogic: ILeaveRequestLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public LeaveRequestLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public string RequestLeave(LeaveRequestModel model)
        {
            var TypeOfLeave = _unitOfWork.GetRepository<LeaveType>().GetAll().Where(x => x.Id == model.LeaveTypeId).FirstOrDefault();
            var getEmployee= _unitOfWork.GetRepository<Employee>().GetAll().Where(x => x.EmployeeId == model.EmployeeId).FirstOrDefault();
            
            var dataModel = new LeaveRequest
            {
                
                EmployeeId = model.EmployeeId,
                LeaveTypeId = model.LeaveTypeId,
                NoOfDays = TypeOfLeave.NoOfDays,
                DateFrom = model.DateFrom,
                DateTo = model.DateFrom.AddDays(TypeOfLeave.NoOfDays),
                ResumptionDate = model.DateFrom.AddDays(TypeOfLeave.NoOfDays+1),
                Status = "pending",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            _unitOfWork.GetRepository<LeaveRequest>().Insert(dataModel);
            _unitOfWork.SaveChanges();
            return $"Congratulations, {getEmployee.FirstName} {getEmployee.LastName} Your Request has been submitted";
        }

    }
}
