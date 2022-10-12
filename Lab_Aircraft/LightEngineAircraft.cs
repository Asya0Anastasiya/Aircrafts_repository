using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Aircraft
{
    class LightEngineAircraft : Aircraft
    {
        private static int capacity;
        static LightEngineAircraft()
        {
            max_speed = 200;
            price = 50;
            flight_range = 400;
            capacity = 200;
        }
        public override void Print_specifications()
        {
            base.Print_specifications();
            Console.WriteLine($"The capacity: {capacity} kg");
        }
    }
}
