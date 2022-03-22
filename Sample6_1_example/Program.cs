using System;

namespace Sample6_1_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("H2Oの温度：");

            double temp;

            temp = double.Parse(Console.ReadLine());

            if (temp >= 100)
            {
                Console.WriteLine("気体");
            }
            else if (temp > 0)
            {
                Console.WriteLine("液体");
            }
            else
            {
                Console.WriteLine("固体");
            }
        }
    }
}
