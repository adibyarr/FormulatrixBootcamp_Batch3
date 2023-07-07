namespace ClassStruct

{
	class ComparisonNumber
	{
		public double DoubleNumber{get; set;}
		public decimal DecimalNumber{get;set;}
		public void NumberCompare()
		{
			if(DoubleNumber == Decimal.ToDouble(DecimalNumber))
			{
				Console.WriteLine("Numbers equal");
			}
			else if(DoubleNumber > Decimal.ToDouble(DecimalNumber))
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
		public double DoubleNumber{get; set;}
		public decimal DecimalNumber{get;set;}
		public void NumberCompare()
		{
			if(DoubleNumber == Decimal.ToDouble(DecimalNumber))
			{
				Console.WriteLine("Numbers equal");
			}
			else if(DoubleNumber > Decimal.ToDouble(DecimalNumber))
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
		static void Main()
		{
			Console.Write("Input double number:");
			double doubleNumber = double.Parse(Console.ReadLine());
			
			Console.Write("Input decimal number: ");
			decimal decimalNumber = decimal.Parse(Console.ReadLine());
			
			NumberComparison comparison = new NumberComparison();
			comparison.DoubleNumber	= doublenumber;
			comparison.DecimalNumber = decimalnumber;
			comparison.ComparisonNumber();
			
			Console.WriteLine();
			
			ComparisonNumberStruct comparisonNumberStruct = new ComparisonNumberStruct();
			comparisonNumberStruct.DoubleNumber = doubleNumber;
			comparisonNumberStruct.DecimalNumber = decimalNumber;
			comparisonNumberStruct.NumberCompare();
		}
	}
}