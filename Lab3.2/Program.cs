using System;

namespace Lab3._2
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3 };
            try
            {
                int result = numbers[4] / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
            }
            try
            {
                int result = numbers[4] / 0;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException: " + ex.Message);
            }
        }
    }
}
