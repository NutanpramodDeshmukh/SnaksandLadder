using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnaksandLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            Random random = new Random();
            int number = random.Next(0,2);
            Console.WriteLine(number);
            if (position < 100)
            {
                position = 0;
                Console.WriteLine("the position is" + position);
            }
            else
            {
                Console.WriteLine("No Player" + position);
            }
        }
    }
}
