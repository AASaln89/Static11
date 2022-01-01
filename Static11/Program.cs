using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER RADIUS");
            double r = Convert.ToDouble(Console.ReadLine());
            double S = Round.S(r);
            double O = Round.Okr(r);
            Console.WriteLine(S);
            Console.WriteLine(O);
            Console.ReadKey();
        }
    }
}