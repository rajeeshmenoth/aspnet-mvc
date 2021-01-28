using EmployeePortal.Managers;
using EmployeePortal.Models;

namespace EmployeePortal.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _employee;
        public BaseEmployeeFactory(Employee employee)
        {
            _employee = employee;
        }

        public Employee Salary()
        {
            IEmployeeManager manager = this.Create();
            _employee.Bonus = manager.GetBonus();
            _employee.HourlyPay = manager.GetHourlyPay();
            return _employee;
        }
        public abstract IEmployeeManager Create();
    }
}