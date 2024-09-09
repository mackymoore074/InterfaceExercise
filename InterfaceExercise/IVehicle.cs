using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public double EngineSize { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public string Make { get; set; }




        public void Drive();
        public void Reverse();
        public void Park();
        public bool changeGears(bool isChanged);
        
    }
}
