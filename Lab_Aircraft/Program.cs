using System;

namespace Lab_Aircraft
{
    class Program
    {
        static void Main(string[] args)
        {
            
          

            Airport airport = new Airport();
            //airport.set_town();
            Console.WriteLine("Choose the type of the aircraft: \n 1. Passenger aircraft\n 2. Private aircraft\n 3. Cargo aircraft\n 4. LightEngine aircraft");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PassengerAircraft passengerAircraft = new PassengerAircraft();
                    passengerAircraft.Flight(airport.Town_from, airport.Town_to);
                    passengerAircraft.maitenance();
                    break;
                case 2:
                    PrivateAircraft privateAircraft = new PrivateAircraft();
                    Console.WriteLine("Please enter the password");
                    string password = Console.ReadLine();
                    if(privateAircraft.Check_password(password) == 1)
                    {
                        Console.WriteLine("Authorization was successful");
                        privateAircraft.Flight(airport.Town_from, airport.Town_to);
                        privateAircraft.maitenance();
                    }
                    else Console.WriteLine("Invalid password");
                    break;
                case 3:
                    CargoAircraft cargoAircraft = new CargoAircraft();
                    cargoAircraft.Flight(airport.Town_from, airport.Town_to);
                    cargoAircraft.Cleaning();
                    cargoAircraft.Cleaning_control_pannel();
                    cargoAircraft.Coffee_for_pilot();
                    Warehouse warehouse = new Warehouse();
                    warehouse.is_loaded = true;
                    Console.WriteLine("The aircraft was unloaded");
                    break;
                case 4:
                    LightEngineAircraft lightEngineAircraft = new LightEngineAircraft();
                    lightEngineAircraft.Flight(airport.Town_from, airport.Town_to);
                    lightEngineAircraft.Cleaning();
                    lightEngineAircraft.Cleaning_control_pannel();
                    lightEngineAircraft.Coffee_for_pilot();
                    break;
                default:
                    Console.WriteLine("Incorrect choice");
                    break;
            }

            /*Aircraft plane1 = new CargoAircraft();
            Aircraft plane2 = new PrivateAircraft();
            plane1.Print_specifications();
            plane2.Print_specifications();*/

        }
    }
}
