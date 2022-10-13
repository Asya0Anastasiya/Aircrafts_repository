using System;

namespace Lab_Aircraft
{
    class PrivateAircraft : Aircraft
    {
        private string owner = "Ilon Mask";
        private string password = "ilon123";

        public int Check_password(string pass)
        {
            if (pass == password) return 1;
            else return 0;
        }

        static PrivateAircraft()
        {
            max_speed = 350;
            price = 500;
            flight_range = 650;
        }
        public override void Print_specifications()
        {
            base.Print_specifications();
            Console.WriteLine($"The name of the owner: {owner}");
        }
    }
}
