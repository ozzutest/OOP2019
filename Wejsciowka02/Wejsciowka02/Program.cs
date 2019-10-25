using System;
namespace Wejsciowka02.Miasto
{
    namespace Wejsciowka02
    {
        class Program
        {
            static void Main(string[] args)
            {
                Miasto obiekt = new Miasto(1000, "Olsztyn");
                
                Console.WriteLine($"{obiekt.nazwaMiasta}");
                Console.WriteLine(obiekt.PodajCeneZaMetr());
            }
        }
    }
}


