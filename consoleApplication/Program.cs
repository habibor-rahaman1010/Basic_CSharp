using consoleApplication.AllClass;

namespace Program {
    static class MainProgram {
        static void Main(string[] args){
            List<ToyotaCar> carList = new List<ToyotaCar>();
            ToyotaCar car1 = new ToyotaCar("Primio", "Meron", 2280000, "Oil Engin", "Petrol and Octen");
            ToyotaCar car2 = new ToyotaCar("Corola", "Black", 1288932, "Oil Engin", "Petrol and Octen");
            ToyotaCar car3 = new ToyotaCar("Voxwagen", "White", 2280000, "Oil Engin", "Digel");
            ToyotaCar car4 = new ToyotaCar("Ferrary", "Red", 25843230, "Oil Engin", "Octen");
            ToyotaCar car5 = new ToyotaCar("Tata Neno", "light Blue", 523893, "Oil Engin", "Petrol and Octen");

            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);
            carList.Add(car4);
            carList.Add(car5);

            foreach (ToyotaCar item in carList)
            {
                item.PrintVehicle();
                Console.WriteLine("\n");
            }
        }
    }
}
