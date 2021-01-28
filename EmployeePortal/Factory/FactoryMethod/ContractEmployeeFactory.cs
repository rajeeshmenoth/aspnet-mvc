using EmployeePortal.Managers;
using EmployeePortal.Models;
using System;

namespace EmployeePortal.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee employee) : base(employee)
        {

        }
        public override IEmployeeManager Create()
        {
            ContractEmployeeManager employeeManager = new ContractEmployeeManager();
            _employee.MedicalAllowance = employeeManager.MedicalAllowance();
            return employeeManager;
        }
    }
}