using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class HanoiTower
    {

        public static  void Move(int numberDisc,string from, string to, string intermidiate)
        {
            if (numberDisc == 1)
            {
                Console.WriteLine("moving dics 1  from " + from + " to " + to);
                return;
            }

            Move(numberDisc - 1, from, intermidiate, to);
            Console.WriteLine($"Moving Discs {numberDisc} from {from}  to {to}");
            Move(numberDisc - 1, intermidiate, to, from);
        }
    }
}
