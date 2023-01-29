using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
               int position = 0;
               Console.WriteLine("Position is " + position);
                Random random = new Random();
                int number = random.Next(0, 7);
                Console.WriteLine(number);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No play");
                        
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        break;
                }
                if (position < 0)
                {
                    position = 0;
                    Console.WriteLine("the position is" + position);
                }
            }
            
    }
}
