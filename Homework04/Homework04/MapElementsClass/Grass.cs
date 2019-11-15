using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Homework04.MapClass;
namespace Homework04.MapElementClass
{
    class Grass : MapElement
    {
       public Grass(int x, int y) : base(x, y, 'G')
        {
            
        }
        public override void  print() => Console.WriteLine($"Grass X: {this.x}, Y: {this.y}");
    }
}
