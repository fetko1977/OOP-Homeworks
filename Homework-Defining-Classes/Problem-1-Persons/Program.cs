using System;

class Persons
{
    private string name; //private field for name
    private int age; //private field for age
    private string email; //private field for email

    public string Name { //public prop for name with validation
        get 
            {
                return this.name;
            } 
        set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("This field is required!");
                }
                else
                {
                    this.name = value;
                }
            } 
    }
    public int Age //public prop for age with validation
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Please enter a valid value in the range [0 - 100].");
            }
            else
            {
                this.age = value;
            }
        }
    }
    public string Email //public prop for email with validation. Note email is optional!
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value == null || value == "")
            {
                this.email = value;
            }
            else
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("This is not a valid email!");
                }
                else
                {
                    this.email = value;
                }
            }
        }
    }

    public Persons(string name, int age, string email = null) //main constructor of the class
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Persons(string name, int age) //seccond constructor which calling the main one
        : this(name, age, null)
    {
    }

    public override string ToString() //public override toString() method for print on the console Persons object as a string
    {
        if (string.IsNullOrEmpty(this.Email))
        {
            return string.Format("Person name is {0} and is {1} years old.", name, age);
        }
        else
        {
            return string.Format("Person name is {0} and is {1} years old. Person email is {2}.", name, age, email);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("*Please enter your name: ");
        string name = Console.ReadLine(); // reading the console input for name. Mandatory!
        Console.Write("*Please enter your age: ");
        int age = int.Parse(Console.ReadLine()); //reading the console input for age. Mandatory!
        Console.Write("Please enter your email: ");
        string email = Console.ReadLine(); //reading the console input for email. Optional!
        

        Persons Person = new Persons(name, age, email); // creating a object from Persons class
        Console.WriteLine(Person); // Print the object on the console
    }
}
