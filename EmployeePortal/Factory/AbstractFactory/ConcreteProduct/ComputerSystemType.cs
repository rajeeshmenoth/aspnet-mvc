using static EmployeePortal.Factory.AbstractFactory.Enumerations;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Laptop.ToString();
        }
    }

    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Desktop.ToString();
        }
    }
}