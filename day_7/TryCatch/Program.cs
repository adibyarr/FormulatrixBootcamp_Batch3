using System;
using TryCatch;

namespace TryCatch
{
    class Program
    {
        static void Main()
        {
            try
            {
                TryCatch.DividedByZeroException();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Terjadi Kesalahan pembagian: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Cek rampung");
            }

            try
            {
                TryCatch.ArrayOutOfRangeException();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Terjadi kesalahan di array: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Cek kelarr");
            }

            try
            {
                TryCatch.IntegerInputByStringException();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Terjadi kesalahan input: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Kelarr ni yee");
            }

            Console.WriteLine("Program kelarr");
        }
    }
}
