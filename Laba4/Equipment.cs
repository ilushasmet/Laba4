using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    abstract class Equipment
    {
        public readonly float max_speed;
        public readonly decimal price;

        public Equipment(decimal price, float speed)
        {
            this.price = price;
            this.max_speed = speed;
        }
    }
    

}
