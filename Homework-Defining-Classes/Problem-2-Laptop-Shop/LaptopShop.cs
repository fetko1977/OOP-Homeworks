using System;

class LaptopShop
{
    static void Main(string[] args)
    {
        Battery battery1 = new Battery("Li-Ion, 4-cells, 2550 mAh", (float)4.5);
        Laptop laptop1 = new Laptop("Lenovo Yoga 2 Pro", (decimal)2259.00, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", battery1);
        Console.WriteLine(laptop1);
        Console.WriteLine("------------------------------------------------------------------------");
        Battery battery2 = new Battery("Li-Ion");
        Laptop laptop2 = new Laptop("Lenovo G580", (decimal)1000.00, null, null, null, null, null, null, battery2);
        Console.WriteLine(laptop2);
        Console.WriteLine("------------------------------------------------------------------------");
        Battery battery3 = new Battery("Li-Ion, 6-cells, 4550 mAh", (float)7.5);
        Laptop laptop3 = new Laptop("MacBook Pro", (decimal)3500.00, "Apple", null, "16GB", null, null, null, battery3);
        Console.WriteLine(laptop3);
    }
}
