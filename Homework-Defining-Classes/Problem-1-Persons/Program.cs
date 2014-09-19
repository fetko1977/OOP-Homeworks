using System;

class Persons
{
    private string name;
    private int age;
    private string email;

    public string Name { 
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
    public int Age 
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
    public string Email 
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

    public Persons(string name, int age, string email = null)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Persons(string name, int age)
        : this(name, age, null)
    {
    }

    public override string ToString()
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
        string name = Console.ReadLine();
        Console.Write("*Please enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Please enter your email: ");
        string line = Console.ReadLine();
        string email = String.IsNullOrEmpty(line) ? "" : line;
        

        Persons Person = new Persons(name, age, email);
        Console.WriteLine(Person);
    }
}
