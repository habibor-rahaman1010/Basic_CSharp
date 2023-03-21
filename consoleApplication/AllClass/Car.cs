using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using consoleApplication.Interface;

namespace consoleApplication.AllClass
{
    public class Car : IVehicle
    {
        public string? name { get; set; }
        public string? color { get; set; }
        public int price { get; set; }
        public string? engineType { get; set; }
        public string? oilType { get; set; }
        
        public Car(string name, string color, int price, string engineType, string oilType){
            this.name = name;
            this.color = color;
            this.price = price;
            this.engineType = engineType;
            this.oilType = oilType;
        }

        public void PrintVehicle()
        {
            throw new NotImplementedException();
        }
        public void move()
        {
            throw new NotImplementedException();
        }
    }
}