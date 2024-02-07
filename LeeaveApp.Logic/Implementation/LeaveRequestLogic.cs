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
            var TypeOfLeave = _unitOfWork.GetRepository<LeaveTypeModelData>().GetAll().Where(x => x.id == model.LeaveTypeId).FirstOrDefault();
            var getEmployee= _unitOfWork.GetRepository<EmployeeModelData>().GetAll().Where(x => x.EmployeeId == model.EmployeeId).FirstOrDefault();
            
            var dataModel = new LeaveRequestModelData
            {
                
                EmployeeId = model.EmployeeId,
                LeaveTypeId = model.LeaveTypeId,
                NoOfDays = TypeOfLeave.NoOfDays,
                DateFrom = model.DateFrom,
                DateTo = model.DateTo,
                ResumptionDate = model.ResumptionDate,
                Status = model.Status,
                DateOfRequest = model.DateOfRequest,
                DateOfLastAction = model.DateOfLastAction
            };
            _unitOfWork.GetRepository<LeaveRequestModelData>().Insert(dataModel);
            _unitOfWork.SaveChanges();
            return $"Congratulations, {getEmployee.FirstName} {getEmployee.LastName} Your Request has been submitted";
        }

    }
}
