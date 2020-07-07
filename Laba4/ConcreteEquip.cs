using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Snowboard : Equipment
    {
        const float MAX_SPEED = 120.3f;

        public Snowboard(decimal price) : base(price, MAX_SPEED) { }
      
    }

    class CrossCountrySkiing : Equipment
    {
        const float MAX_SPEED = 158.3f;

        public CrossCountrySkiing(decimal price) : base(price, MAX_SPEED) { }

    }

    class Ski : Equipment
    {
        const float MAX_SPEED = 100.3f;

        public Ski(decimal price) : base(price, MAX_SPEED) { }

    }

    interface Printer
    {
        void printClass(Equipment eq);
    }

    class EquipmentPrinter : Printer
    {
        public void printClass(Equipment eq)
        {
            Console.WriteLine("Instance of class "+ eq.GetType() +" with price = "+ eq.price.ToString() + "$" +  " and max speed = " + eq.max_speed.ToString());
        }
    }

}
