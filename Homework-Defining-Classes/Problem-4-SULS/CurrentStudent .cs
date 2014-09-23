using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    public class CurrentStudent : Student
    {
        //field with current student courses taken
        private string currentCourse;

        public CurrentStudent(string firstName, string lastName, uint studentNumber, decimal averageGrade, string currentCourse, int age = 0)
            : base(firstName, lastName, studentNumber, averageGrade, age)
        {
            this.CurrentCourse = currentCourse;
        }

        //Property Current Course with validation
        public string CurrentCourse 
        {
            get { return this.currentCourse; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Current Course can't be empty!");
                }
                this.currentCourse = value;
            }
        }

        //Method for String Represantation 
        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();
            studentInfo.AppendLine(string.Format("First name: {0}", this.FirstName));
            studentInfo.AppendLine(string.Format("Last name: {0}", this.LastName));
            studentInfo.AppendLine(string.Format("Age: {0}", this.Age));
            studentInfo.AppendLine(string.Format("Student number: {0}", this.StudentNumber));
            studentInfo.AppendLine(string.Format("Average grade: {0}", this.AverageGrade));
            studentInfo.AppendLine(string.Format("Current course: {0}", this.CurrentCourse));
            return studentInfo.ToString();
        }
    }
}
