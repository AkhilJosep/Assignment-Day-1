using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Q17
    {
        static void Main()
        {
            Console.WriteLine("Enter the first word");
            string a=Console.ReadLine();
            Console.WriteLine("Enter the second word");
            string b=Console.ReadLine();
            if (a == b) 
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not same");
            }

        }
    }
}
