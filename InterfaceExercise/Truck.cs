using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck :IVehicle, ICompany
    {
        public int BedWidthFt { get; set; }
        public int BedHeightFt { get; set; }

        public string Slogan { get; set; }
        public string Logo { get; set; }

        public int NumOfTires { get; set; }
        public bool HasWindows { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
