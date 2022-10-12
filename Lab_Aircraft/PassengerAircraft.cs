using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Aircraft
{
    class PassengerAircraft : Aircraft
    {
        private static int num_of_seats;
        static PassengerAircraft()
        {
            max_speed = 300;
            price = 100;
            flight_range = 600;
            num_of_seats = 20; 
        }
        public override void Print_specifications()
        {
            base.Print_specifications();
            Console.WriteLine($"Number of seats: {num_of_seats}");
        }
    }
}
