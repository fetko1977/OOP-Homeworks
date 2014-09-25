using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_BitArray
{
    class TestBitArray
    {
        static void Main(string[] args)
        {
            //Instance of BitArray 
            BitArray number = new BitArray(10);
            //changing some indexes
            number[5] = 1;
            number[7] = 1;
            Console.WriteLine(number);
            number[5] = 0;
            Console.WriteLine(number);
        }
    }
}
