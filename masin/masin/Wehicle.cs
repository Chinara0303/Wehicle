using System;
using System.Collections.Generic;
using System.Text;

namespace masin
{
    class Wehicle
    {
        public string Model;
        public string Brand;
        public int Speed;
        public string Color;
        public int Litr;
        public Wehicle(string model, string brand, int speed, string color, int litr)
        {
            Model = model;
            Brand = brand;
            Speed = speed;
            Color = color;
            Litr = litr;

            
        }
        public int Average()
        {
            return Litr * 100;
        }



    }
}
