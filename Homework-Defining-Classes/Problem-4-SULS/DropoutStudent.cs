using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    class DropoutStudent : Student
    {
        //field dropoutReason
        private string dropoutReason;

        //Constructor
        public DropoutStudent(string firstName, string lastName, uint studentNumber, decimal averageGrade, string dropoutReason, int age = 0)
            : base(firstName, lastName, studentNumber, averageGrade, age)
        {
            this.DropoutReason = dropoutReason;
        }

        //Prop DropoutReason
        public string DropoutReason 
        {
            get { return this.dropoutReason; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Dropout Reason can't be null or empty!");
                }
                this.dropoutReason = value;
            }
        }

        //Method for Reapply
        public void Reapply()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(new string('*', 30));
            str.AppendLine(string.Format("First name: {0}", this.FirstName));
            str.AppendLine(string.Format("Last name: {0}", this.LastName));
            str.AppendLine(string.Format("Age: {0}", this.Age));
            str.AppendLine(string.Format("Student number: {0}", this.StudentNumber));
            str.AppendLine(string.Format("Average grade: {0:F2}", this.AverageGrade));
            str.AppendLine("Dropout reason:");
            str.AppendLine(string.Format("    {0}", this.DropoutReason));
            str.AppendLine(new string('*', 30));
            Console.WriteLine(str.ToString());
        }
    }
}
