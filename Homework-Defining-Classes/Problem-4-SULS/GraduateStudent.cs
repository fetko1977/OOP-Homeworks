using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    class GraduateStudent : Student
    {
        public GraduateStudent(string firstName, string lastName, uint studentNumber, decimal averageGrade, int age = 0)
            : base(firstName, lastName, studentNumber, averageGrade, age)
        {
        }
    }
}
