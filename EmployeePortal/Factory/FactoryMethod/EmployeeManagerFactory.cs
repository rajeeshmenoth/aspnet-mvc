using EmployeePortal.Models;

namespace EmployeePortal.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            BaseEmployeeFactory employeeFactory = null;

            if (employee.EmployeeTypeID == 1)
            {
                employeeFactory = new PermanentEmployeeFactory(employee);
            }
            else if(employee.EmployeeTypeID == 2)
            {
                employeeFactory = new ContractEmployeeFactory(employee);
            }

            return employeeFactory;
        }
    }
}