using EmployeePortal.Models;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee employee)
        {
            IComputerFactory computerFactory = null;
            if (employee.EmployeeTypeID == 1)
            {
                if(employee.JobDescription == "Manager")
                {
                    computerFactory = new MACFactory();
                }
                else
                {
                    computerFactory = new MACLaptopFactory();
                }
            }
            else if (employee.EmployeeTypeID == 2)
            {
                if (employee.JobDescription == "Manager")
                {
                    computerFactory = new DellFactory();
                }
                else
                {
                    computerFactory = new DellLaptopFactory();
                }
            }

            return computerFactory;
        }
    }
}