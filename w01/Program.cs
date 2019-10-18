using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ex3
            double masa, wzrost;
            Console.WriteLine("Podaj swoja wage: ");
            masa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wzrost: ");
            wzrost = Convert.ToDouble(Console.ReadLine());
            if (wzrost > 0 & masa > 0)
                Console.WriteLine($"wynik: {(double)(masa / (wzrost * wzrost))}");
            else
                Console.WriteLine($"Nieprawidlowe dane.");
        }
    }
}
