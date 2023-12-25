using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Q8
    {
        static void Main() 
        {
            int fact = 1;
            Console.WriteLine("Enter a number");
            int a=int.Parse(Console.ReadLine());
            for(int i=1;i<=a;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);

        }  
    }
}
