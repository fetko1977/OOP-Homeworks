using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    public class SULSTest
    {
        static void Main(string[] args)
        {
            JuniorTrainer juniorTrainer1 = new JuniorTrainer("Pesho", "Peshov", 24);
            JuniorTrainer juniorTrainer2 = new JuniorTrainer("GonlineStudentho", "GonlineStudentov", 27);
            JuniorTrainer juniorTrainer3 = new JuniorTrainer("Vladko", "Vladov", 19);
            SeniorTrainer seniorTrainer1 = new SeniorTrainer("Petko", "Petkov", 33);
            SeniorTrainer seniorTrainer2 = new SeniorTrainer("Stefan", "Stefanov", 38);
            SeniorTrainer seniorTrainer3 = new SeniorTrainer("Martin", "Martinov", 29);
            GraduateStudent graduateStudent1 = new GraduateStudent("Ivan", "Novakov", 30020925, 4.45M, 35);
            GraduateStudent graduateStudent2 = new GraduateStudent("RadonlineStudentlav", "Simeonov", 30058925, 5.80M, 28);
            GraduateStudent graduateStudent3 = new GraduateStudent("Teodor", "Stoychev", 300521345, 3.00M, 33);
            DropoutStudent dropoutStudent1 = new DropoutStudent("Nakovalnq", "Nakovalnev", 30020925, 4.45M, "...", 35);
            DropoutStudent dropoutStudent2 = new DropoutStudent("Mmmm", "IdropOut", 30058925, 5.80M, "I dropoutStudentn't care zzzZZZzzz...", 28);
            DropoutStudent dropoutStudent3 = new DropoutStudent("Arnold", "Ill' be back", 300521345, 3.00M, "Terminated!!!", 33);
            OnlineStudent onlineStudent1 = new OnlineStudent("Emil", "Stefanov", 40018512, 3.33M, "OOP", 48);
            OnlineStudent onlineStudent2 = new OnlineStudent("Martin", "Todorov", 40065415, 5.45M, "OOP", 22);
            OnlineStudent onlineStudent3 = new OnlineStudent("Valeri", "Zahariev", 40018525, 4.89M, "OOP", 18);
            OnsiteStudent onsiteStudent1 = new OnsiteStudent("Natalya", "Alexandrova", 40089564, 4.00M, "OOP", 5, 31);
            OnsiteStudent onsiteStudent2 = new OnsiteStudent("Adriyana", "Alexandrova", 40012188, 5.25M, "OOP", 5, 25);
            OnsiteStudent onsiteStudent3 = new OnsiteStudent("Peter", "Simeonov", 40035698, 3.80M, "OOP", 3, 30);

            juniorTrainer1.CreateCourse("PHP Basics");
            seniorTrainer1.CreateCourse("Java Basics");
            seniorTrainer2.DeleteCourse("PHP Basics");
            dropoutStudent3.Reapply();

            List<Person> softUniPersons = new List<Person> 
            { 
                juniorTrainer1,
                juniorTrainer2,
                juniorTrainer3,
                seniorTrainer1,
                seniorTrainer2,
                seniorTrainer3,
                graduateStudent1,
                graduateStudent2,
                graduateStudent3,
                dropoutStudent1,
                dropoutStudent2,
                dropoutStudent3,
                onsiteStudent1,
                onsiteStudent2,
                onsiteStudent3,
                onlineStudent1,
                onlineStudent2,
                onlineStudent3 
            };

            SULS testSoftUni = new SULS(softUniPersons);
            testSoftUni.ExtractCurrentStudents();
        }
    }
}