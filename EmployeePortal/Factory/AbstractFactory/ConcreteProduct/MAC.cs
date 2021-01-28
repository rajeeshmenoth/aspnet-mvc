using static EmployeePortal.Factory.AbstractFactory.Enumerations;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class MAC : IBrand
    {
        public string GetBrand()
        {
            return Brands.APPLE.ToString();
        }
    }
}