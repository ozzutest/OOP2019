using System;
using System.Collections.Generic;
using System.Text;
using Homework04.MapClass;
namespace Homework04.MapElementsClass
{
    class Rock : MapElement
    {
        public Rock(int x, int y) :base(x, y, 'R')
        {

        } 
        public override void print() => Console.WriteLine($"Rock X: {this.x}, Y: {this.y}");
    }
}
