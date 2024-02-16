using Leave_App.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeeaveApp.Logic.Interface
{
    public interface ILeaveBalanceLogic
    {
        LeaveBalanceModel leaveBalance(string employeeId);
    }
}
