using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Problem_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            string name;
            Console.WriteLine("Tell me your name!");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);
            Console.ReadLine();

            //Problem 2
            Console.WriteLine("Question 2 Below:");
            int a = int.MaxValue;
            int b = int.MinValue;

            float c = float.MaxValue;
            float d = float.MinValue;

            decimal e = decimal.MaxValue;
            decimal f = decimal.MinValue;

            double g = double.MaxValue;
            double h = double.MinValue;

            //Print Values
            Console.WriteLine("Int max: {0}.  Int min: {1}", a, b);
            Console.WriteLine("Float max: {0}.  Float min: {1}", c, d);
            Console.WriteLine("Decimal max: {0}.  Decimal min: {1}", e, f);
            Console.WriteLine("Double max: {0}.  Int min: {1}", g, h);

            Console.ReadLine();

        }
    }
}
