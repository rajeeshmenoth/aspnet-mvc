namespace EmployeePortal.Builder.IBuilder
{
    public interface ISystemBuilder
    {
        void AddMemory(string memory);
        void AddDrive(string size);

        void AddMouse(string type);
        void AddKeyBoard(string type);

        void AddTouchScreen(string enabled);
        ComputerSystem GetSystem();
    }
}
