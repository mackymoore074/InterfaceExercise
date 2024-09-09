using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {

        }
        public double EngineSize { get; set; } = 4.5;
        public int NumberOfDoors { get; set; } = 4;
        public int NumberOfSeats { get; set; } = 5;
        public string Make { get; set; } = "Hyundai";
        public string Name { get; set; } = "Sekina";
        public string Title { get; set; } = "DriveTime";
        public bool HasTrunk { get; set; } = true;
        public bool HaschangeGears { get; set; }

      

        public void Drive()
        {
          
            Console.WriteLine($"{GetType().Name}Vroom Vroom");

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
            if (HaschangeGears == true)
            {
                Console.WriteLine($"{GetType().Name} Parking");
                HaschangeGears = false;
            }
            else
            {
                Console.WriteLine("Please change gears");
            }
        }
        public bool changeGears(bool isChanged)
        {
            return isChanged;
        }

    }

}
