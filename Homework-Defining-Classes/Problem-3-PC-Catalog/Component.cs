using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Component
{
    //private fields
    private string name;
    private string details;
    private decimal price;
    // Constructors
    public Component(string name, string details, decimal price)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }

    public Component(string name, decimal price)
        : this(name, null, price)
    {
    } 
    //Props
    public string Name 
    {
        get { return this.name; }
        set
        {
            if (!String.IsNullOrEmpty(value))
            {
                this.name = value;
            }
            else
            {
                throw new ArgumentException("Name can't be null or empty!");
            }
        }
    }

    public string Details 
    {
        get
        {
            return details;
        }
        set
        {
            this.details = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value > 0)
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentException("Price can't be negative!");
            }
        }
    }

    public override string ToString()
    {
        string str = String.Format("Component: (Name: {0}, ", this.Name);
        if (!String.IsNullOrEmpty(this.Details))
        {
            str += "Details: " + this.Details + ", ";
        }
        str += String.Format("Price: {0:F2} {1:BGN})", this.Price, this.Price);
        return str.ToString();
    }
}
