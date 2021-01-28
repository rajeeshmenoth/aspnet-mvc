namespace EmployeePortal.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 8;
        }

        public decimal GetHourlyPay()
        {
            return 15;
        }

        public decimal MedicalAllowance()
        {
            return 2000;
        }
    }
}