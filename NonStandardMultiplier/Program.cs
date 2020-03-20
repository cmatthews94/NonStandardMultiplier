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

            Console.WriteLine(Multiply(4.14, 16.5));
            Console.WriteLine(Multiply(-4.14, -16.5));
            Console.WriteLine(Multiply(-4.14, 16.5));
            Console.WriteLine(Multiply(4.14, -16.5));

        }
        static double Multiply(double a, double b)
        {
            double count = 0;
            ValueSet numbersGiven = SetLowerHigherInt(a, b);

            for (int i = 0; i < Math.Abs(numbersGiven.IntLower); i++)
            {
                count += numbersGiven.IntHigher;
            }
            return numbersGiven.IntLower < 0 ? -count : count; 

        }
        static ValueSet SetLowerHigherInt(double a, double b)
        {
            return Math.Abs(a) > Math.Abs(b) ? new ValueSet { IntHigher = a, IntLower = b } : new ValueSet { IntHigher = b, IntLower = a };
        }
    }
    public class ValueSet
    {
        public double IntHigher { get; set; }
        public double IntLower { get; set; }
    }
}

