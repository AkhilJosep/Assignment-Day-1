using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Q11
    {
        static void Main()
        {
            int a = 200, b = 300;
            for(int i =a;i<=b;i++)
            {
                if(i%7==0)
                {
                    Console.WriteLine(i+" ");
                }
            }
        }
    }
}
