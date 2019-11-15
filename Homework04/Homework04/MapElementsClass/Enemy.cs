using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Homework04.MapClass;
namespace Homework04.MapElementsClass
{
    class Enemy : PointClass
    {
        public string name { get; set; }
        public int level { get; set; }

        public Enemy(int level, string name, int y, int x) : base(x, y)
        {
            this.level = level;
            this.name = name;
        }

        public override void print() => Console.WriteLine($"{this.name}, {this.level}, X: {this.x}, Y: {this.y}");
    }
}
