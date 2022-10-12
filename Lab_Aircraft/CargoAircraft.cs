using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Aircraft
{
    class CargoAircraft: Aircraft
    {
        public int load_capacity;

        CargoAircraft()
        {
            max_speed = 300;
            price = 20;
            flight_range = 700;
            load_capacity = 1000;
        }

        CargoAircraft(int max_speed, int price, int flight_range, int load_capacity)
        {
            this.max_speed = max_speed;
            this.price = price;
            this.flight_range = flight_range;
            this.load_capacity = load_capacity;
        }


        public override string ToString()
        {
            return base.ToString() + $"The load capacity: {load_capacity} kg";
        }
    }
}
