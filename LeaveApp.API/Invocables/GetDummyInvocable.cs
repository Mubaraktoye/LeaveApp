using Coravel.Invocable;
using LeeaveApp.Logic.Interface;
using System.Threading.Tasks;

namespace LeaveApp.API.Invocables
{
    public class GetDummyInvocable: IInvocable
    {
        private readonly IRegisterEmployeeLogic _regEmployee;

        public GetDummyInvocable(IRegisterEmployeeLogic regEmployee)
        {
            _regEmployee = regEmployee;
        }

        public async Task Invoke()
        {
            _regEmployee.GetDummyString();
        }
    }
}
