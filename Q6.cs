using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Q6
    {
        static void Main()
        {
            {
                int cel;
                Console.WriteLine("Enter the temperature in fahrenheit:");
                int far = int.Parse(Console.ReadLine());
                cel = ((far - 32) * (5 / 4));
                Console.WriteLine(cel);
            }
        }
    }
}
