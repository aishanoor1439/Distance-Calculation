using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Initial velocity:");
            double vi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Final velocity:");
            double vf = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time duration:");
            double t = Convert.ToDouble(Console.ReadLine());
            double v = Convert.ToDouble(vf-vi);
            double s = v * t;
            Console.WriteLine("Distance(s) covered = " + s);

        }
    }
}
