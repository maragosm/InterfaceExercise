using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car() { TrunkWidthIn = 40, TrunkHeightIn = 35, Slogan = "If you ain't first, you're last", Logo = "Ram", NumOfTires = 4, HasWindows = true, Make = "Dodge", Model = "Avenger" };
            var truck1 = new Truck() { BedWidthFt = 4, BedHeightFt = 1, Slogan = "If you ain't first, you're last", Logo = "Ram", NumOfTires = 6, HasWindows = true, Make = "Dodge", Model = "RAM Dually" };
            var suv1 = new SUV() { CargoDepthFt = 3, FoldedSeatCargoDepthFt = 4, Slogan = "If you ain't first, you're last", Logo = "Ram", NumOfTires = 4, HasWindows = true, Make = "Dodge", Model = "Durango" };

            var vehicles = new List<object>();
            vehicles.Add(car1);
            vehicles.Add(truck1);
            vehicles.Add(suv1);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Below are the properties of our {vehicle.GetType().Name}:");
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(vehicle))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(vehicle);
                    Console.WriteLine("{0}={1}", name, value);
                }
                Console.WriteLine("----------------");
            }
        }
    }
}
