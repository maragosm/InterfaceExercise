using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int CargoDepthFt { get; set; }
        public int FoldedSeatCargoDepthFt { get; set; }

        public string Slogan { get; set; }
        public string Logo { get; set; }

        public int NumOfTires { get; set; }
        public bool HasWindows { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
