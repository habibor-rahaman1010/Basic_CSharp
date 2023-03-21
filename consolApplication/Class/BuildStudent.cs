namespace BuildStudent{
    class Student{
        public int id;
        public string name;
        public string level;
        public string subject;
        public string email;
        public string phone;
      

       public Student(int id, string name, string level, string subject, string email, string phone){
            this.id = id;
            this.name = name;
            this.level = level;
            this.subject = subject;
            this.email = email;
            this.phone = phone;
        }

        public void PrintStudent(){
            Console.WriteLine("Id: " +id);
            Console.WriteLine("Name: " +name);
            Console.WriteLine("Class: " +level);
            Console.WriteLine("Subject: " +subject);
            Console.WriteLine("Email: " +email);
            Console.WriteLine("Phone: " +phone);
        }
    }
}