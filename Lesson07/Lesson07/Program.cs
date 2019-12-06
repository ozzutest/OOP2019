using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson07.ProductClass;
namespace Lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new App();
            while (true)
            {
                obj.ReadKey();
                obj.DoAction();
            }
            
        }
    }
}
