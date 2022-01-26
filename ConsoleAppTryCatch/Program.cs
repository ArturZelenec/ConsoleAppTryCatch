using System;

namespace ConsoleAppTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format");
            }
        }
    }
}
