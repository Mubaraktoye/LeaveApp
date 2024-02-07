using Leave_App.Model.Data;
using LeeaveApp.Logic.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeaveApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveBalanceController : ControllerBase
    {
        private readonly ILeaveBalanceLogic _leaveBalanceLogic;

        public LeaveBalanceController(ILeaveBalanceLogic leaveBalanceLogic)
        {
            _leaveBalanceLogic = leaveBalanceLogic;
        }
        [HttpGet("{employeeId}")]
        public ActionResult Get(int employeeId) 
        {
            var result = _leaveBalanceLogic.leaveBalance(employeeId);
            return Ok(result);
        }
    }
}
