using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int n);
            for (int i = 1; i <= n; i++)
            {
                string str = "";
                if (i % 3 == 0)
                {
                    str += "Fizz";
                }
                if (i % 5 == 0)
                {
                    str += "Buzz";
                }
                if (str.Length == 0)
                {
                    str = i.ToString();
                }
                Console.WriteLine(str);
            }
        }
    }
}
