using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Square_Root
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an positive integer number: ");
            string input = Console.ReadLine();

            try
            {
                int num = Int32.Parse(input);
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double result = Math.Sqrt(num);
                Console.WriteLine(result);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("This number cannot be negative!");
            }
            catch (FormatException)
            {
                Console.WriteLine("The value you've entered is not a integer number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The value you've entered is bigger than max value of integer type!");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Operation!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
