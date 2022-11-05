using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }
        override public string ToString()
        {
            return (numerator + "/" + denominator);
        }
    }
    internal class Property
    {
        public static void Main()
        {
            Fraction f = new Fraction();
            int i;
            f.Numerator = 1;        // Numerator에서 set을 호출
            i = f.Numerator + 1;    // Numerator에서 get을 호출
            f.Denominator = i;      // Denominator에서 set을 호출
            Console.WriteLine(f.ToString());
        }
    }
}
