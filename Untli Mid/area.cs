using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    internal class area
    {
        static void Main(String[] args)
        {
            double height, wid;
            double area;
            string line;
            string[] field;

            Console.Write("Enter height & width  :  ");
            line = Console.ReadLine();
            field = line.Split(' ');

            height = double.Parse(field[0]);
            wid = double.Parse(field[1]);
            area = height * wid;
            Console.WriteLine("area = " + area);
        }
    }
}
