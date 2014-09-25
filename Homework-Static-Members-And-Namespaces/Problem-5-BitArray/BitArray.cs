using System;
using System.Numerics;

namespace Problem_5_BitArray
{
    class BitArray
    {
        //private field array of bytes
        private byte[] bits;

        //Constructor with validation for the number of bits
        public BitArray(int n)
        {
            if (n < 1 || n > 100000)
            {
                throw new ArgumentOutOfRangeException("The bits should be in the range [1...100000]");
            }
            this.bits = new byte[n];
        }

        //public property for geting and setting the index of related bit
        public byte this[int index]
        {
            get { return this.bits[index]; }
            set
            {
                if (index < 0 || index > this.bits.Length - 1)
                {
                    throw new ArgumentOutOfRangeException("The value must be in the range: [0..." + (this.bits.Length - 1) + "]!");
                }
                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("Invalid value for current bit! Values can be 0 or 1!");
                }
                this.bits[index] = value;
            }
        }

        //String override with algorithm to return the decimal represantation of the number as a string
        public override string ToString()
        {
            BigInteger num = 0;
            for (int i = 0; i < this.bits.Length; i++)
            {
                int bit = this.bits[i];
                if (bit == 1)
                {
                    num += BigInteger.Pow(2, i);
                }
            }
            return num.ToString();
        }
    }
}
