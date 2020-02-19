using System;
namespace ConsoleApp1
{
    public class Program
    {
        public static int Swapper(int a, int b)
        {
            a = b;
            return a;
        }
        public static void Main(string[] args)
        {
            int a = 4, b = 5, c = 6;
            Console.WriteLine("A=" + a + " B=" + b + " C=" + c);
            int result_a = Swapper(a, c);
            int result_b = Swapper(b, a);
            int result_c = Swapper(c, b);
            Console.WriteLine("New A=" + result_a + " New B=" + result_b + " New C=" + result_c);
            Console.ReadLine();
        }
    }
}