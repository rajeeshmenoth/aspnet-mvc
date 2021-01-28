using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class Enumerations
    {
        public enum ComputerTypes
        {
            Laptop,
            Desktop
        }

        public enum Brands
        {
            APPLE,
            DELL,
            HP
        }

        public enum Processors
        {
            I5,
            I7
        }

        public enum GraphicCards
        {
            Nvidia,
            AMD,
            GeForce,
            InternalUHD
        }
    }
}