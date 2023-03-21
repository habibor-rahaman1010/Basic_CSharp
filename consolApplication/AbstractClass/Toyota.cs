namespace AbstactClass{
    public class Toyota : Vechils{
        public string? regNo {get; protected set;}
        public string? oilType {get; protected set;}
        public bool discount {get; set;}

        public Toyota(string name, string color, int price, string brand, string origin, string regNo, string oilType, bool discount)
        : base(name, color, price, brand, origin){
            this.regNo = regNo;
            this.oilType = oilType;
            this.discount = discount;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Color: {this.color}");
            Console.WriteLine($"Price: {this.price}");
            Console.WriteLine($"Brand: {this.brand}");
            Console.WriteLine($"Origin: {this.origin}");
            Console.WriteLine($"Register No: {this.regNo}");
            Console.WriteLine($"Oil: {this.oilType}");
            Console.WriteLine($"Discount: {this.discount}");
        }
    }
}