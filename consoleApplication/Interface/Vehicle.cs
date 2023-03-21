using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApplication.Interface
{
    public interface IVehicle
    {
        public string? name { set; get; }
        public string? color { get; set; }
        public int price { get; set; }
        public string? engineType { get; set; }
        public string? oilType { get; set; }

        public void PrintVehicle();
        public void move();
    }
}