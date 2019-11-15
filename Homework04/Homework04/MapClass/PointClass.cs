using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Homework04.MapClass
{
    public class PointClass
    {
        public int x, y;
        public PointClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        } 
        public virtual void print() => Console.WriteLine($"X: {this.x}, Y: {this.y}");

    }
}
