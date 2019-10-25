using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson03.CarClass
{
    class Car
    {
        static int iloscKol = 4;
        private double pojemnoscSilnika;
        private string marka;

        public double PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { value = pojemnoscSilnika; }
        }
        public Car(double pojemnoscSilnika, string marka)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
        }

        public string Marka
        {
            get { return marka; }
            set { value = marka; }
        }

        public static int IloscKol
        {
            get {return iloscKol; }
            set { value = iloscKol; }
        }

        public Car CreateCar()
        { 
            return new Car(this.pojemnoscSilnika, this.marka);
        }
    }
}
