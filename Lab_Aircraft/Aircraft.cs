using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Aircraft
{
    class Aircraft : Maintenance
    {
        public int max_speed;
        public int price;
        public int flight_range;

         public override string ToString()
        {
            return $"The maximum speed of your aircraft: {max_speed} \nThe ticket price: {price} $\n The maximum flight range: {flight_range} km ";
        }

        public void Flight(string town_from, string town_to)
        {
            Console.WriteLine($"The flight has begun from {town_from}");
            Console.WriteLine("We are going to accelerate");
            Console.WriteLine("Climbing now");
            Console.WriteLine("Flying among the clouds");
            Console.WriteLine("We are going to reduce the height");
            Console.WriteLine($"Arrived at the destination at {town_to}");
        }

        public void Cleaning()
        {
            Console.WriteLine("Cleaning the windows and the seats");
        }

        public void Cleaning_control_pannel()
        {
            Console.WriteLine("Cleaning the control pannel");
        }

        public void Coffee_for_pilot()
        {
            Console.WriteLine("Coffee break for pilot");
        }

        public void maitenance()
        {
            Cleaning();
            Cleaning_control_pannel();
            Coffee_for_pilot();
        }
    }
}
