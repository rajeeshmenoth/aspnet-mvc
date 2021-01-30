using EmployeePortal.Builder.IBuilder;

namespace EmployeePortal.Builder.ConcreteBuilder
{
    public class LaptopBuilder : ISystemBuilder
    {
        ComputerSystem laptop = new ComputerSystem();
        public void AddDrive(string size)
        {
            laptop.SDDSize = size;
        }

        public void AddKeyBoard(string type)
        {
            return;
        }

        public void AddMemory(string memory)
        {
            laptop.RAM = memory;
        }

        public void AddMouse(string type)
        {
            return;
        }

        public void AddTouchScreen(string enabled)
        {
            laptop.TouchScreen = enabled;
        }

        public ComputerSystem GetSystem()
        {
            return laptop;
        }
    }
}