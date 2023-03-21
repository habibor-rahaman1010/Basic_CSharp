using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApplication.AllClass
{
    public class ToyotaCar : Car
    {
        public ToyotaCar(string name, string color, int price, string engineType, string oilType) : base(name, color, price, engineType, oilType){

        }

        public new void PrintVehicle()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Color: {this.color}");
            Console.WriteLine($"Name: {this.price}");
            Console.WriteLine($"Engin Type: {this.engineType}");
            Console.WriteLine($"Oil Type: {this.oilType}");
        }
    }
}