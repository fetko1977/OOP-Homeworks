using System;
using System.Text;

class Battery
{
    private string type;
    private float hours;

    public Battery(string type) : this(type, 0)// Constructor with type only chaining to the main one
    {
    }

    public Battery(string type, float hours)// Constructor main
    {
        this.Type = type;
        this.Hours = hours;
    }

    public string Type
    { 
        get { return this.type; }
        set 
        {
            if (!String.IsNullOrEmpty(value)) // checking for null or empty string the type property
            {
                this.type = value;
            }
            else
            {
                throw new ArgumentException("Value can't be empty or null!");
            }
        }
    }

    public float Hours
    {
        get { return this.hours; }
        set
        {
            if (value >= 0)// checking the hours for negative value
            {
                this.hours = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Value can't be negative!");
            }
        }
    }

    public override string ToString() // public override method ToString() to display Battery Object Data as String
    {
        string str = "";
        if (this.Hours > 0)
        {
            str = String.Format("battery: {0}\nbattery life: {1:F1} hours", this.Type, this.Hours);
        }
        else if (this.Hours == 0)
        {
            str = String.Format("battery: {0}", this.Type);
        }
        else
        {
            throw new ArgumentException("Value can't be negative!");
        }
        return str.ToString();
    }
}

