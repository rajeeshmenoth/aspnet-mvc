namespace EmployeePortal.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 8;
        }

        public decimal HourlyPay()
        {
            return 15;
        }
    }
}