using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumOfTires { get; set; }
        public bool HasWindows { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

    }
}
