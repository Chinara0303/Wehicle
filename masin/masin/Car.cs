using System;
using System.Collections.Generic;
using System.Text;

namespace masin
{
    class Car:Wehicle
    {
        public Car (string model, string brand, int speed, string color,int litr) : base(model, brand, speed, color,litr)
        {
            Model = model;
            Brand = brand;
            Speed = speed;
            Color = color;
            Console.WriteLine($"{Model} {Brand}");

        }
    }
   
}
