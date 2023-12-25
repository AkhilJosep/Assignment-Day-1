using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Q10
    {
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int a=int.Parse(Console.ReadLine());
            for (int i = 1;i<=20;i++)
            {
                Console.WriteLine(i*a);
            }
        }
    }
}
