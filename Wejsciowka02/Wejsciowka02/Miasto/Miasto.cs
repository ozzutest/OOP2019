using System;
using System.Collections.Generic;
using System.Text;

namespace Wejsciowka02.Miasto
{
    class Miasto
    {
        public int liczbaLudnosci;
        public string nazwaMiasta;

        public Miasto(int liczbaLudnosci, string nazwaMiasta)
        {
            this.liczbaLudnosci = liczbaLudnosci;
            this.nazwaMiasta = nazwaMiasta;
        }
        public string PodajCeneZaMetr()
        {
            if (liczbaLudnosci == 1000)
                return "Cena za metr^2 mieszknia: 5000zl";
            else if (liczbaLudnosci == 2000)
                return "Cena za metr^2 mieszkania: 10000zl";

            return "Wrong data!";
        }
    }
}
