using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, uint studentNumber, decimal averageGrade, string currentCourse, int age = 0)
            : base(firstName, lastName, studentNumber, averageGrade, currentCourse, age)
        {
        }
    }
}
