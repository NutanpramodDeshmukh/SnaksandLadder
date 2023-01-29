using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDice
{
    internal class Program
    {
        static void Main()
        {
            int Diceroll = 0;
            Random random = new Random();
            int number = random.Next(0, 7);
            Console.WriteLine("Number of dice rolls " + Diceroll);
            Console.WriteLine(number);
        }
    }
}
