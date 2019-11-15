using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
namespace Homework04.MapClass
{
    public class MapElement : PointClass
    {
        public char icon;

        public MapElement(int x, int y, char icon) : base(x, y)
        {
            this.icon = icon;
        }
    }
}
