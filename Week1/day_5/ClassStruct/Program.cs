using System;

namespace ClassStruct
{
    class ComparisonNumber
    {
        public double DoubleNumber { get; set; }
        public decimal DecimalNumber { get; set; }
        public void NumberCompare()
        {
            if (DoubleNumber == Decimal.ToDouble(DecimalNumber))
            {
                Console.WriteLine("Numbers equal");
            }
            else if (DoubleNumber > Decimal.ToDouble(DecimalNumber))
            {
                Console.WriteLine("Numbers greater than");
            }
            else
            {
                Console.WriteLine("Decimal greater than");
            }
        }
    }

    struct ComparisonNumberStruct
    {
        public double DoubleNumber { get; set; }
        public decimal DecimalNumber { get; set; }
        public void NumberCompare()
        {
            if (DoubleNumber == Decimal.ToDouble(DecimalNumber))
            {
                Console.WriteLine("Numbers equal");
            }
            else if (DoubleNumber > Decimal.ToDouble(DecimalNumber))
            {
                Console.WriteLine("Numbers greater than");
            }
            else
            {
                Console.WriteLine("Decimal greater than");
            }
        }
    }

    class Program
    {
        private static double doublenumber;
        private static decimal decimalnumber;

        static void Main()
        {
            Console.Write("Input double number: ");
            double doubleNumber = double.Parse(Console.ReadLine());

            Console.Write("Input decimal number: ");
            decimal decimalNumber = decimal.Parse(Console.ReadLine());

            ComparisonNumber comparison = new ComparisonNumber();
            comparison.DoubleNumber = doubleNumber;
            comparison.DecimalNumber = decimalNumber;
            comparison.NumberCompare();

            Console.WriteLine();

            ComparisonNumberStruct comparisonNumberStruct = new ComparisonNumberStruct();
            comparisonNumberStruct.DoubleNumber = doubleNumber;
            comparisonNumberStruct.DecimalNumber = decimalNumber;
            comparisonNumberStruct.NumberCompare();
        }
    }
}
