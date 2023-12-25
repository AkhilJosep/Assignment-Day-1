using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Q5
    {static void Main()
        {
            int[] oddev = new int[10];
            int limit;
            int oddc = 0, evenc = 0;
            Console.WriteLine("Enter the limit:");
            limit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < limit; i++)
            {
                oddev[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < limit; i++)
            {
                if (oddev[i] % 2 == 0)
                {
                    evenc++;
                }
                else
                {
                    oddc++;
                }
            }
            Console.WriteLine($"Odd number={oddc} Even number={evenc}");

        }
    }
}
