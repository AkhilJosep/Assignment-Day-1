using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Q4
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int a=Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");
        }
    }
}
