using BuildStudent;
using AbstactClass;

namespace StudentNamespace
{
    class Program{
        static void Main(string[] args){
            Student student = new Student(144369, "Habibor Rahaman", "University", "Computer Science", "habibor1010@gmail.com", "01768280237");
            Habib stu = new Habib(144369, "Habibor Rahaman", "University", "Computer Science", "habibor.rahaman1010@gmail.com", "01768280237", "Musnshigonj - Dhaka", 3.50);
            //stu.PrintHabib();

            //create abstruct class object and call...
            BMW bmw = new BMW("Seven Series", "Black", 22050888, "BMW", "United of state");
            //bmw.PrintInfo();

            Toyota toyo = new Toyota("Primio", "Megenda", 1875780, "TOYOTA", "Japan", "#8923834", "Petrol and Octen", true);
            toyo.PrintInfo();
        }
    } 
}
