using System;

namespace masin
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Kicks","Nissan",300,"White",2);
            Car car2 = new Car("Juke", "Nissan", 350, "White", 1);
            Console.WriteLine(car1.Average());
            Console.WriteLine(car2.Average());
        }
    }
}
