namespace Exercises
{
    internal class Q18
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.WriteLine("Enter a string");
            string s=Console.ReadLine();
            for (int i=0,j=s.Length-1;i<s.Length;i++,j--)
            {
                if (s[i] != s[j])
                {
                    flag=1;
                }
            } 
            if (flag == 0) 
            {
                Console.WriteLine("palindrom");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }
    }
}
