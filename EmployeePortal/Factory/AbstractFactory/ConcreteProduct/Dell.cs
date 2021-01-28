using static EmployeePortal.Factory.AbstractFactory.Enumerations;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return Brands.DELL.ToString();
        }
    }
}