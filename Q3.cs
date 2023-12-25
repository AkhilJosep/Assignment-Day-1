using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Q3
    {
        static void Main()
        {
            Console.WriteLine("Enter 2 number");
             int a = int.Parse(Console.ReadLine());
             int b=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Numbers are: ");
            for(int i=a;i<=b;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
