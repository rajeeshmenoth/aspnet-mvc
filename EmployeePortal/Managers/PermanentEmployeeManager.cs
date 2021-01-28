namespace EmployeePortal.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetHourlyPay()
        {
            return 5;
        }

        public decimal GetHouseAllowance()
        {
            return 1000;
        }
    }
}