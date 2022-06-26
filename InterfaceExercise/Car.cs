using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int TrunkWidthIn { get; set; }
        public int TrunkHeightIn { get; set; }

        public string Slogan { get; set; }
        public string Logo { get; set; }

        public int NumOfTires { get; set; }
        public bool HasWindows { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
