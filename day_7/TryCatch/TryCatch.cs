using TryCatch;
namespace TryCatch
{
	public class TryCatch
	{
		public static void DividedByZeroException()
		{
			int num1 = 12;
			int num2 = 0;
			int result = num1 / num2;
			Console.WriteLine("Hasil pembagian: " + result);	
		}
		public static void ArrayOutOfRangeException()
		{
			int[] numbers = {1,2,3,4,5};
			Console.WriteLine("Elemen ke 7:" + numbers[7]);
		}
		public static void IntegerInputByStringException()
		{
			int[] number = {2};
			number.ToString();
			Console.WriteLine("Angka yang ada: "+ number);
		}
	}
}