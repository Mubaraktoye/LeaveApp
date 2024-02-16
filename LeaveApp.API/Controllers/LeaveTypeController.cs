using Leave_App.Model.Data;
using LeeaveApp.Logic.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeaveApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypeController : ControllerBase
    {
        private readonly IleaveTypelogic _leaveTypelogic;

        public LeaveTypeController(IleaveTypelogic leaveTypelogic
            )
        {
            _leaveTypelogic = leaveTypelogic;
        }
        [HttpPost]
        public ActionResult Get(LeaveTypeModel model)
        {
            var result = _leaveTypelogic.AddLeaveType(model);
            return Ok(result);
        }
    }
}
