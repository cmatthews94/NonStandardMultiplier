using System;

namespace NonStandardMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(4, 5));
            Console.WriteLine(Multiply(-4, -5));
            Console.WriteLine(Multiply(4, -5));
            Console.WriteLine(Multiply(-4, 5));
            Console.WriteLine(Multiply(-6, -5));

            Console.WriteLine(Multiply(4.14, 16.5));
            Console.WriteLine(Multiply(-4.14, -16.5));
            Console.WriteLine(Multiply(-4.14, 16.5));
            Console.WriteLine(Multiply(4.14, -16.5));

        }
        static double Multiply(double a, double b)
        {
            double count = 0;
            NumberSet numberSet = SetLowerHigherInt(a, b);

            for (int i = 0; i < Math.Abs(numberSet.LowerNumber); i++)
            {
                count += numberSet.HigherNumber;
            }
            return numberSet.LowerNumber < 0 ? -count : count; 

        }
        static NumberSet SetLowerHigherInt(double a, double b)
        {
            return Math.Abs(a) > Math.Abs(b) ? new NumberSet { HigherNumber = a, LowerNumber = b } : new NumberSet { HigherNumber = b, LowerNumber = a };
        }
    }
    public class NumberSet
    {
        public double HigherNumber { get; set; }
        public double LowerNumber { get; set; }
    }
}

