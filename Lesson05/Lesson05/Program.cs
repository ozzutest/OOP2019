using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson05.VehiclesClass;
using Lesson05.PersonClass;
using Lesson05.I;
namespace Lesson05
{
    class Program 
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Ride();
            Bicycle bicycle = new Bicycle();
            bicycle.Ride();
            // when you want to evoke method like IGuitarist.Play() you should call your interface
            IGuitarist person = new Person();
            IViolinist newPerson = new Person();
            Person newPerson1 = new Person();
            newPerson.Play();
            person.Play();
            newPerson1.Play();
        }
    }
}
