using EmployeePortal.Managers;

namespace EmployeePortal.Factory
{
    public class EmployeeManagerFactory
    {
        /// <summary>
        /// Get employee details using the type id.
        /// </summary>
        /// <param name="employeeTypeId"></param>
        /// <returns></returns>
        public IEmployeeManager GetEmployeeManager(int employeeTypeId)
        {
            IEmployeeManager employeeManager = null;
            if (employeeTypeId == 1)
            {
                employeeManager = new PermanentEmployeeManager();
            }
            else if (employeeTypeId == 2)
            {
                employeeManager = new ContractEmployeeManager();
            }

            return employeeManager;
        }
    }
}