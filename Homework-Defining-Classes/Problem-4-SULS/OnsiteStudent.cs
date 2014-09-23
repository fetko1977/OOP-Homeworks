using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    class OnsiteStudent : CurrentStudent
    {
        //Fields
        private int visits;

        //Constructor
        public OnsiteStudent(string firstName, string lastName, uint studentNumber, decimal averageGrade, string currentCourse, int visits = 0, int age = 0)
            : base(firstName, lastName, studentNumber, averageGrade, currentCourse, age)
        {
            this.Visits = visits;
        }

        //Props
        public int Visits 
        {
            get { return this.visits; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Visits can't be negative value!");
                }
                this.visits = value;
            }
        }
    }
}
