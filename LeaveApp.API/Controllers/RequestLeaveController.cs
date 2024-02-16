using Leave_App.Model.Data;
using LeeaveApp.Logic.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeaveApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestLeaveController : ControllerBase
    {
        private readonly ILeaveRequestLogic _leaveRequestLogic;

        public RequestLeaveController(ILeaveRequestLogic leaveRequestLogic)
        {
            _leaveRequestLogic = leaveRequestLogic;
        }
        [HttpPost]
        public ActionResult RequestLeave(LeaveRequestModel model)
        {
            var result = _leaveRequestLogic.RequestLeave(model);
            return Ok(result);
        }
    }
}
