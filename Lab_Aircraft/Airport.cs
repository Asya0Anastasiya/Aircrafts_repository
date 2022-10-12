using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Aircraft
{
    class Airport
    {
        public string Town_from; //{ get; set; }
        public string Town_to; //{ get; set; }

        public Airport()
        {
            Console.WriteLine("Choose the city you'll fly from");
            Town_from = Console.ReadLine();
            Console.WriteLine("Choose the destination");
            Town_to = Console.ReadLine();
        }

    }
}
