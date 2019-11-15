using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Schema;
using Homework04.IMap;
using Homework04.MapElementClass;
using Homework04.MapElementsClass;

namespace Homework04.MapClass
{
    class Map : IMap.IMap
    {
            public MapElement[,] array;
            public Enemy[] enemys;
        public void generate()
        {
            int x, y;
            string input;
            do
            {
                Console.Write($"Please enter a point of array(x): ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out x) || x < 0);

            do
            {
                Console.Write($"Please enter a point of array(y): ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out y) || y < 0);

            this.array = new MapElement[x, y];
            
            Random rnd = new Random();

            int counter = 0;

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    int number = rnd.Next(1, 10);
                   if (number < 3)
                       this.array[i, j] = new Rock(i, j);
                   else if (number < 5) 
                       this.array[i ,j] = new Tree(i, j);
                   else
                   {
                       this.array[i, j] = new Grass(i, j);
                       counter++;
                   }
                }

            counter -= rnd.Next(1, counter - 1);

            int z = 0;

            this.enemys = new Enemy[counter];

            foreach (MapElement a in this.array)
            {
                if (counter <= 0)  
                    break;
                if (a is Grass)
                {
                    this.enemys[z] = new Enemy(100, "Enemy", a.y, a.x);
                    z++;
                    counter--;
                }
            }

        }
        public void list()
        {
            for (int i = 0; i < this.array.GetLength(0); i++)
                for (int j = 0; j < this.array.GetLength(1); j++)
                    this.array[i, j].print();
        }

        public void show()
        {
            for (int i = 0; i < this.array.GetLength(0); i++)
            { 
                for (int j = 0; j < this.array.GetLength(1); j++)
                     Console.Write($"{this.array[i, j].icon}");
                Console.WriteLine();
            }
        }
    }
}
