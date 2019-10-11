using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 5, 10, 15, 20 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }

            Console.WriteLine("\n");

            //task 2

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    Console.WriteLine($"{array[i]}" + " ");
                else
                    Console.WriteLine($"{array[i]}" + ", ");
            }

            // task 3
            Console.WriteLine("\n");

            Array.Reverse(array);

            for (int i = 0; i < array.Length; i++)
                 Console.WriteLine($"{array[i]}");

            // task 4
            Console.WriteLine("\n");

            int a = 5, b = 10;

            if (a > b)
                Console.WriteLine("{0} > {1}", a, b);
            else if (a == b)
                Console.WriteLine("{0} = {b}", a, b);
            else
                Console.WriteLine("{0} < {1}", a, b);

            Console.WriteLine("\n");

            // check integers to create triangle

            Console.WriteLine("Enter an integer: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third integer: ");
            int e = Convert.ToInt32(Console.ReadLine());

            if (a + d > e && a + e > d && d + e > a)
                Console.WriteLine("These integers are eligble to create a triangle.\n");
            else
                Console.WriteLine("These given integers are not eligible to create a triangle.\n");


            // task 5

            int integer;

            do
            {
                Console.WriteLine("Enter an integer: ");
                integer = Convert.ToInt32(Console.ReadLine());
            } while (integer < 5 || integer > 15);

            Console.WriteLine("\n");

            while (integer >= 0)
                   Console.WriteLine($"{integer--}");

            // task 6

            do
            {
                Console.WriteLine("Enter an integer: ");
                integer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Given number does not meet the requirements.\n");
            } while (integer < 4 || integer > 7);

            if (integer > 4 && integer < 7 && integer != 10) // last condition is not necessary
                Console.WriteLine("Given number does not meet the requirements.\n");
            else;


        }
    }
}
