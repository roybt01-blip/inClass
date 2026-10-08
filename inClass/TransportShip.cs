using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inClass
{
    public class TransportShip : BaseShip
    {
        public TransportShip(int i) : base(5)
        {
            Console.WriteLine("Transport ship constructor");
        }
        public override string Move(int Distance)
        {
            return $"Transportship Covered distance {Distance}";
        }
        public override string ToString()
        {
            return $"TransportShip hello from TOSTRING";
        }
    }
}
