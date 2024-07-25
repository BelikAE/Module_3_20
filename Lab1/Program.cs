using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = D;
            myDelegate += S;
            myDelegate += V;
            myDelegate(3);
            Console.ReadKey();
        }

        static double D(double r) 
        {
            double d = 2*Math.PI*r;
            Console.WriteLine(d);
            return d;
        }

        static double S(double r)
        {
            double s =  Math.PI * Math.Pow(r, 2);
            Console.WriteLine(s);
            return s;

        }
        static double V(double r)
        {
            double v = 4.00/3*Math.PI * Math.Pow(r,3);
            Console.WriteLine(v);
            return v;
        }
    }
}
