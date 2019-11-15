using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson05.VehiclesClass;
using Lesson05.I;
namespace Lesson05.VehiclesClass
{
    class Bicycle : Vehicle, IRideable
    {
        public void Ride() => Console.WriteLine($"I'm riding a bicycle.");
    }
}
