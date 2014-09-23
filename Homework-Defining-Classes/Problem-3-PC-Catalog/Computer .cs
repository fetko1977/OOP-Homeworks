using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Computer
{
    // Fields
    private string name;
    private List<Component> components;

    //Properties
    public string Name 
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name can't be null or empty!");     
            }
            this.name = value;
        }
    }

    public List<Component> Components
    {
        get { return this.components; }
        set
        {
            if (value == null)
            {
                throw new ArgumentException("Components can't be null!");
            }
            this.components = value;
        }
    }

    public decimal Price
    {
        get { return this.Components.Sum(a => a.Price); }
    }

    //Constructor
    public Computer(string name, List<Component> components)
    {
        this.Name = name;
        this.Components = components;
    }

    // String Method Override
    public override string ToString()
    {
        string str = String.Format("Computer: {0}\nComponents: ", this.Name);
        foreach (Component component in Components)
        {
            str += component + "\n";   
        }
        str += String.Format("Price: {0:F2} {1:BGN}", this.Price, this.Price);
        return str.ToString();
    }
}
