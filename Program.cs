using System.Data;

namespace midtest_01_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 15;
                int b = 5;
                int c = a / b;
                string[] names = new string[5];
                string id = names[4];

                if (b > 10)
                {
                    throw new ArithmeticException("b大於10");
                }

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error1");
                Console.WriteLine(ex.ToString());
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error2");
                Console.WriteLine(ex.ToString());
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine("Error3");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("最終執行");
            }
        }
    }
}
