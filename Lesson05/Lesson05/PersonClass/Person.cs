using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson05.I;
namespace Lesson05.PersonClass
{
    class Person : IGuitarist, IViolinist
    {
        public void Play() => Console.WriteLine("I play but i don't know what to do.");

        void IGuitarist.Play() => Console.WriteLine("I play the guitar.");

        void IViolinist.Play() => Console.WriteLine("I play the violin");
    }
}


