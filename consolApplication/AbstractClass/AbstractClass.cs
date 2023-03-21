namespace AbstactClass{
    public abstract class Vechils{
        public string? name {get; protected set;}
        public string? color {get; protected set;}
        public int price {get; protected set;}
        public string? brand {get; protected set;}
        public string? origin {get; protected set;}

        public Vechils(){
            
        }
        public Vechils(string name, string color, int price, string brand, string origin){
            this.name = name;
            this.color = color;
            this.price = price;
            this.brand = brand;
            this.origin = origin;
        }

        public abstract void PrintInfo();
    }
}