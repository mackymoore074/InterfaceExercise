using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    { 
        public Truck()
        {

        }
        public bool HasFourWheelDrive { get; set; }
        public double EngineSize { get; set; } = 6;
        public int NumberOfDoors { get; set; } = 4;
        public int NumberOfSeats { get; set; } = 7;
        public string Make { get; set; } = "Toyota";
        public string Name { get; set; } = "Takoma";
        public string Title { get; set; } = "RoadTrips";
        public bool HasTrunk { get; set; } = true;
        public bool HaschangeGears { get; set; }



        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"{GetType().Name} Vroom Vroom");
            }
            else
            {
                Console.WriteLine("Please engage 4WD");
            } 
        }
        public void Reverse()
        {
            if (HaschangeGears == true)
            {
                Console.WriteLine($"{GetType().Name} Beep Beep");
                HaschangeGears = false;
            }
            else
            {
                Console.WriteLine("Please change gears");
            }
        }
        public void Park()
        {
            Console.WriteLine("Parking");
        }
        public bool changeGears(bool isChanged)
        {
            return isChanged;
        }

    }

}
