using System;
using System.Runtime.CompilerServices;
using Homework04.MapClass;
using Homework04.MapElementsClass;
namespace Homework04
{
    class Program 
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            map.generate();
            map.list();
            map.show();

            foreach (Enemy e in map.enemys)
            {
                e.print();
            }

        }
    }
}
