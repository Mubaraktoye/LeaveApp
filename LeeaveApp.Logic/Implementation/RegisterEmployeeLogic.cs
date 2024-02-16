using Arch.EntityFrameworkCore.UnitOfWork;
using Leave_App.Model;
using Leave_App.Model.Data;
using Leave_App.Model.View;
using LeeaveApp.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeeaveApp.Logic.Implementation
{
    public class RegisterEmployeeLogic : IRegisterEmployeeLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public RegisterEmployeeLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public string RegisterEmployee(EmployeeModel model)
        {
            //model validation to enforce value on employee id and others
            //check if an employee already exist
            //var generateEmployeeId = 000;
            var dataModel = new Employee
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                EmployeeId = model.EmployeeId,
                CreatedDate= DateTime.Now
            };
            _unitOfWork.GetRepository<Employee>().Insert(dataModel);
            _unitOfWork.SaveChanges();
            return $"Congratulationds {model.FirstName} {model.LastName}, you have been registeed";
        }
        public string UpdateEmployeee(EmployeeModel model) 
        {
            var UserRecord = _unitOfWork.GetRepository<Employee>().GetAll().Where(x => x.EmployeeId == model.EmployeeId).FirstOrDefault();

            UserRecord.FirstName = model.FirstName;
            UserRecord.LastName = model.LastName;
            UserRecord.Email = model.Email;
            UserRecord.PhoneNumber = model.PhoneNumber;
            UserRecord.UpdatedDate= DateTime.Now;
            _unitOfWork.GetRepository<Employee>().Update(UserRecord);
            _unitOfWork.SaveChanges();
            return "Success";
        }
        public string DeleteEmpolyee(string employeeId)
        {
            var UserRecord = _unitOfWork.GetRepository<Employee>().GetAll().Where(x => x.EmployeeId == employeeId).FirstOrDefault();
            _unitOfWork.GetRepository<Employee>().Delete(UserRecord);
            _unitOfWork.SaveChanges();
            return "Deleted";
        }
    }
}
