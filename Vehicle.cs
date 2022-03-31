using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionTask
{
    class Vehicle
    {
        public string Color;
        public string Brand;
        public int Millage;
        public virtual void ShowInfo()
        {
            Console.WriteLine("Brand: {brand}  + Color: {Color}  + Millage: {Millage}");
        }

    }
}
