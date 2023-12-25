using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Q12
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());    
            int c=int.Parse(Console.ReadLine());
            if (a>b)
            {
                if(a>c)
                {
                    Console.WriteLine(a + " is greater");
                }
                else
                {
                    Console.WriteLine(c + " is greater");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine(b + " is greater");
                }
                else
                {
                    Console.WriteLine(c + " is greater");
                }

            }
        }
    }
}
