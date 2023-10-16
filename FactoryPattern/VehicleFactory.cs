using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string wheelCount)
        {
            switch (wheelCount.ToLower())
            {
                case "4":
                case "four":
                    return new Car();
                case "2":
                case "two":
                    return new Motorcycle();
                default: 
                    return new Car();

            }



        }
    }
}
