using EmployeePortal.Managers;
using EmployeePortal.Models;

namespace EmployeePortal.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee employee) : base(employee)
        {

        }
        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager employeeManager = new PermanentEmployeeManager();
            _employee.HouseAllowance = employeeManager.GetHouseAllowance();
            return employeeManager;
        }
    }
}