using System.Diagnostics;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete chislo"); 
            int n = int.Parse(Console.ReadLine());
            int temp = 1;
            for (int i = 0; i <= n; i++)
            {
                for (int a = 0; a < i; a++)
                {
                    Console.Write($"{temp++} ");
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}