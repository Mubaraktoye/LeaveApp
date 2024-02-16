using Leave_App.Model.Data;
using Leave_App.Model.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeeaveApp.Logic.Interface
{
    public interface IRegisterEmployeeLogic
    {
        string RegisterEmployee(EmployeeModel model);

        string GetDummyString();

    }
}
