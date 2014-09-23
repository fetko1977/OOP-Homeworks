using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    public class Person
    {
        //Fields
        private string firstName;
        private string lastName;
        private int age;

        //Properties
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (!String.IsNullOrEmpty(value) && value.Length > 3)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("FirstName can't be null or empty, or less than 3 chars!");
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (!String.IsNullOrEmpty(value) && value.Length > 3)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("LastName can't be null or empty, or less than 3 chars!");
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("This value can't be negative!");
                }
                this.age = value;
            }
        }

        //Constructors

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Person(string firstName, string lastName)
            : this(firstName, lastName, 0)
        {
        }

        //Method for string represenatation
        public override string ToString()
        {
            string str = String.Format("{2} - Name: {0} {1}.", this.FirstName, this.LastName, GetType().Name);
            if (this.Age != 0)
            {
                str += " Age: " + this.Age + "years.";
            }
            return str.ToString();
        }
    }
}