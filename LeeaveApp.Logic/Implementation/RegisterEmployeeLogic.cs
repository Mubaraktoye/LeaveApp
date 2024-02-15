using Arch.EntityFrameworkCore.UnitOfWork;
using Leave_App.Model;
using Leave_App.Model.Data;
using LeeaveApp.Logic.Interface;
using System;
using System.Collections.Generic;
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
            //var generateEmployeeId = 000;
            var dataModel = new Employee
            {
                
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                EmployeeId = model.EmployeeId
            };
            _unitOfWork.GetRepository<Employee>().Insert(dataModel);
            _unitOfWork.SaveChanges();
            return $"Congratulationds {model.FirstName} {model.LastName}, you have been registeed";
        }

        public string GetDummyString()
        {
            Console.WriteLine("Hello! my worker");
            return "Hello! my worker";
        }
    }
}
