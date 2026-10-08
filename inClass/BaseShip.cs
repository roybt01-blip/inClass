using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace inClass
{
    public class BaseShip
    {
        private int counter;
        protected int speed;

        public BaseShip(int i)
        {
            Console.WriteLine("this is base ship, this is base ship costructor");
        }
        public virtual string Move(int Distance)
        {
            counter++;
            return $"Base ship covered distance {Distance}";
        }
    }
}
