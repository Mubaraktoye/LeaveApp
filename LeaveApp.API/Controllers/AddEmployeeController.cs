using Leave_App.Model.Data;
using LeeaveApp.Logic.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeaveApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddEmployeeController : ControllerBase
    {
        private readonly IRegisterEmployeeLogic _RegisterEmployeeLogic;

        public AddEmployeeController(IRegisterEmployeeLogic registerEmployeeLogic)
        {
            _RegisterEmployeeLogic = registerEmployeeLogic;
        }
        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel model)
        {
            var result = _RegisterEmployeeLogic.RegisterEmployee(model);
            return Ok(result);
        }
    }
}
