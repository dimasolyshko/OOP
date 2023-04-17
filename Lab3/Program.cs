using System;
namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -3;
            const int b = 0;
            int result = 1;
            try
            {
                result = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникло исключение! {ex.Message}");
                try
                {
                    result = a / b;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Возникло повторное исключение! {ex.Message}");
                }
            }
        }
    }
}
