using System;

class NumberComparison
{
    public double DoubleNumber { get; set; }
    public decimal DecimalNumber { get; set; }

    public void CompareNumbers()
    {
        if (DoubleNumber == Decimal.ToDouble(DecimalNumber))
        {
            Console.WriteLine("The numbers are equal.");
        }
        else if (DoubleNumber > Decimal.ToDouble(DecimalNumber))
        {
            Console.WriteLine("The double number is greater than the decimal number.");
        }
        else
        {
            Console.WriteLine("The decimal number is greater than the double number.");
        }
    }

    internal void ComparisonNumber()
    {
        throw new NotImplementedException();
    }
}

struct NumberComparisonStruct
{
    public double DoubleNumber { get; set; }
    public decimal DecimalNumber { get; set; }

    public void CompareNumbers()
    {
        if (DoubleNumber == Decimal.ToDouble(DecimalNumber))
        {
            Console.WriteLine("The numbers are equal.");
        }
        else if (DoubleNumber > Decimal.ToDouble(DecimalNumber))
        {
            Console.WriteLine("The double number is greater than the decimal number.");
        }
        else
        {
            Console.WriteLine("The decimal number is greater than the double number.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the double number: ");
        double doubleNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the decimal number: ");
        decimal decimalNumber = decimal.Parse(Console.ReadLine());

        NumberComparison comparison = new NumberComparison();
        comparison.DoubleNumber = doubleNumber;
        comparison.DecimalNumber = decimalNumber;
        comparison.CompareNumbers();

        Console.WriteLine();

        NumberComparisonStruct comparisonStruct = new NumberComparisonStruct();
        comparisonStruct.DoubleNumber = doubleNumber;
        comparisonStruct.DecimalNumber = decimalNumber;
        comparisonStruct.CompareNumbers();

        Console.ReadLine();
    }
}
