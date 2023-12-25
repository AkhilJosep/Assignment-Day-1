using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Q13
    {
        static void Main()
        {
            int[] a = new int[5];
            int small = a[0];
            Console.WriteLine("Enter five numbers");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < small)
                {
                    small = a[i];
                }
            }
        }
    }
}
