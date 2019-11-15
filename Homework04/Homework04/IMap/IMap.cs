using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Homework04.IMap
{
    interface IMap
    {
        void generate();

        void list();

        void show();
    }
}
