using System;
using Lesson03.CarClass;

namespace Lesson03
{
     class Program
     {
         static void Main(string[] args)
         {
            Car car = new Car(4000, "Lexus");
            Car car4 = new Car(5000, "Lamborghini");
            //2.nie mozna
            Console.WriteLine($"{car.PojemnoscSilnika}, {car.Marka}");
            Car car2 = car.CreateCar();
            Console.WriteLine($"{car2.PojemnoscSilnika}, {car2.Marka}");
            Car car3 = car4.CreateCar();
            Console.WriteLine($"{car4.PojemnoscSilnika}, {car4.Marka}");

            Console.WriteLine(Car.IloscKol);

            
         }
     }
}


