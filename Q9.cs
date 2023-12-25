using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Q9
    {
      static void Main()
        {
            //01123581321345589
            Console.WriteLine("Enter the number of elements");
            int n=int.Parse(Console.ReadLine());
            int first = 0, second = 1, next;
            Console.Write(first + " " + second+" ");
            for(int i = 0; i < n; i++)
            {
                next = first + second;
                Console.Write(next+" ");
                first = second;
                second=next;
            }
        }
    }
}
