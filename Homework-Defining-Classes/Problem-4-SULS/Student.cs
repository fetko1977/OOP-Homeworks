using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    public abstract class Student : Person
    {
        // Fields
        private uint studentNumber;
        private decimal averageGrade;
        
        //Constructor
        public Student(string firstName, string lastName, uint studentNumber, decimal averageGrade, int age = 0)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        //Props
        public uint StudentNumber 
        {
            get { return this.studentNumber; }
            set
            {
                if (value < 1 || value > uint.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Out of accepted range between 1 and uint.MaxValue!");
                }
                this.studentNumber = value;
            }
        }

        public decimal AverageGrade
        {
            get { return this.averageGrade; }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Out of accepted range between 2 and 6!");
                }
                this.averageGrade = value;
            }
        }
    }
}
