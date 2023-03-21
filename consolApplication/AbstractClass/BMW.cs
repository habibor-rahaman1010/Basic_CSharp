namespace AbstactClass{
    public class BMW : Vechils{
        public BMW(string name, string color, int price, string brand, string origin) : base(name, color, price, brand, origin){}

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Color: {this.color}");
            Console.WriteLine($"Price: {this.price}");
            Console.WriteLine($"Brand: {this.brand}");
            Console.WriteLine($"Origin: {this.origin}");
        }
    }
}