using System;
using System.Text;

class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private string ram;
    private string hdd;
    private string graphicsCard;
    private string screen;
    private Battery battery;
    private decimal price;

    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.price = price;
    }

    public Laptop(string model, decimal price, string manufacturer = null, string processor = null, string ram = null, string graphicsCard = null, string hdd = null, string screen = null, Battery battery = null)
        : this(model, price)
    {
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.Hdd = hdd;
        this.GraphicsCard = graphicsCard;
        this.Screen = screen;
        this.Battery = battery;
    }

    public string Model 
    {
        get { return this.model; } 
        set
        {
            if (value != "") // checking for null or empty string validating Model property
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentException("Model can't be empty!");
            }
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (value != "") // checking for null or empty string validating Manufacturer property
            {
                this.manufacturer = value;
            }
            else
            {
                throw new ArgumentException("Manufacturer can't be empty!");
            }
        }
    }

    public string Processor
    {
        get { return this.processor; }
        set
        {
            if (value != "") // checking for null or empty string validating Processor property
            {
                this.processor = value;
            }
            else
            {
                throw new ArgumentException("Processor can't be empty!");
            }
        }
    }

    public string Ram
    {
        get { return this.ram; }
        set
        {
            if (value != "") // checking for null or empty string validating Ram property
            {
                this.ram = value;
            }
            else
            {
                throw new ArgumentException("Ram can't be empty!");
            }
        }
    }

    public string Hdd
    {
        get { return this.hdd; }
        set
        {
            if (value != "") // checking for null or empty string validating Hdd property
            {
                this.hdd = value;
            }
            else
            {
                throw new ArgumentException("Hdd can't be empty!");
            }
        }
    }

    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (value != "") // checking for null or empty string validating GraphicsCard property
            {
                this.graphicsCard = value;
            }
            else
            {
                throw new ArgumentException("GraphicsCard can't be empty!");
            }
        }
    }

    public string Screen
    {
        get { return this.screen; }
        set
        {
            if (value != "") // checking for null or empty string validating Screen property
            {
                this.screen = value;
            }
            else
            {
                throw new ArgumentException("Screen can't be empty!");
            }
        }
    }

    public Battery Battery
    {
        get { return this.battery; }
        set { this.battery = value; }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value > 0) // checking for negative value validating Price property
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentException("Price can't be negative!");
            }
        }
    }

    public override string ToString() // public override method ToString()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine("model: " + this.Model);
        if (!String.IsNullOrEmpty(this.Manufacturer)) { str.AppendLine("manufacturer: " + this.Manufacturer); }
        if (!String.IsNullOrEmpty(this.Processor)) { str.AppendLine("processor: " + this.Processor); }
        if (!String.IsNullOrEmpty(this.Ram)) { str.AppendLine("ram: " + this.Ram); }
        if (!String.IsNullOrEmpty(this.GraphicsCard)) { str.AppendLine("graphics card: " + this.GraphicsCard); }
        if (!String.IsNullOrEmpty(this.Hdd)) { str.AppendLine("hdd: " + this.Hdd); }
        if (!String.IsNullOrEmpty(this.Screen)) { str.AppendLine("screen: " + this.Screen); }
        if (this.Battery != null) { str.AppendLine(this.Battery.ToString()); }
        str.Append(String.Format("price: {0:F2} lv.", this.Price));
        return str.ToString();
    }
}
