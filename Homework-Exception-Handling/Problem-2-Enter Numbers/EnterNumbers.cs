using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Enter_Numbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 100;
            int[] numbers = new int[10];
            Console.WriteLine("Please enter ten numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isInvalid = false;
                do {
                    try
                    {
                        numbers[i] = ReadNumbers(start, end);
                        if (i > 0)
                        {
                            if (numbers[i] < numbers[i - 1])
                            {
                                throw new ArithmeticException();
                            }
                        }
                        isInvalid = false;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Number must be in range [{0}...{1}]!", start, end);
                        Console.WriteLine("Please enter new value: ");
                        isInvalid = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The value is not a number!");
                        Console.WriteLine("Please enter new value: ");
                        isInvalid = true;
                    }
                    catch (ArithmeticException)
                    {
                        Console.WriteLine("The current value can't be lower than the previous value!");
                        Console.WriteLine("Please enter new value: ");
                        isInvalid = true;
                    }
                } while (isInvalid);
            }
        }

        public static int ReadNumbers(int start, int end)
        {
            string input = Console.ReadLine();
            int num = Int32.Parse(input);
            if (num < start || num > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return num;
        }
    }
}
