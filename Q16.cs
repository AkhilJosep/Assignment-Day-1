using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Q16
    {
        static void Main()
        {
            Console.WriteLine("Enter a string");
            string a=Console.ReadLine();    
            for(int i=a.Length-1;i>=0;i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}
