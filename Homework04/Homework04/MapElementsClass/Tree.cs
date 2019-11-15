using System;
using System.Collections.Generic;
using System.Text;
using Homework04.MapClass;
namespace Homework04.MapElementClass
{
    class Tree : MapElement
    {
        public Tree(int x, int y) : base(x, y, 'T')
        {

        }
        public override void print() => Console.WriteLine($"Tree X: {this.x}, Y: {this.y}");
    }
}
