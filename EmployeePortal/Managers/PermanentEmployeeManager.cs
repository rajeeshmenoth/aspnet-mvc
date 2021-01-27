namespace EmployeePortal.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal HourlyPay()
        {
            return 5;
        }
    }
}