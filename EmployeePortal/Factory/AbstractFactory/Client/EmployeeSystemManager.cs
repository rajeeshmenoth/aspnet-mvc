using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class EmployeeSystemManager
    {
        private IComputerFactory _computerFactory;
        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            _computerFactory = computerFactory;
        }

        public string GetSystemDetails()
        {
            IBrand brand = _computerFactory.Brand();
            IProcessor processor = _computerFactory.Processor();
            ISystemType systemType = _computerFactory.SystemType();
            string systemDetails = string.Format("{0},{1},{2}", brand.GetBrand(), processor.GetProcessor(), systemType.GetSystemType());
            return systemDetails;
        }
    }
}