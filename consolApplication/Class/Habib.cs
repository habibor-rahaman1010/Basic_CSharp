namespace BuildStudent{
    class Habib : Student{
      public string address;
      public double cgpa;
       public Habib(int id, string name, string level, string subject, string email, string phone, string address, double cgpa) : base(id, name, level, subject, email, phone){
            this.address = address;
            this.cgpa = cgpa;
        }

        public void PrintHabib(){
            Console.WriteLine("Id: " +id);
            Console.WriteLine("Name: " +name);
            Console.WriteLine("Class: " +level);
            Console.WriteLine("Subject: " +subject);
            Console.WriteLine("Email: " +email);
            Console.WriteLine("Phone: " +phone);
            Console.WriteLine("Phone: " +address);
            Console.WriteLine("Phone: " +cgpa);
        }
    }
}