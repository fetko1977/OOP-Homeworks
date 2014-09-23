using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PCCatalog
{
    static void Main(string[] args)
    {
        Component motherBoard1 = new Component("AsusP8H67/H67/1155", "Game Station", (decimal)155.00);
        Component graphicCard1 = new Component("ATI Radeon HD7850", (decimal)229.00);
        Component ram1 = new Component("2x4GB DDR3 1600Mhz", (decimal)129.00);
        Computer pc1 = new Computer("Asus Game Machine", new List<Component> { motherBoard1, graphicCard1, ram1 });
        Console.WriteLine(pc1);
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------------");
        Component motherBoard2 = new Component("ASUS P8H61-M LX2/SI/LGA1155", "Home Station", (decimal)98.00);
        Component graphicCard2 = new Component("ATI Radeon HD 7750", (decimal)138.00);
        Component ram2 = new Component("4 GB DDR3 1333 MHz", (decimal)65.00);
        Computer pc2 = new Computer("Home Machine", new List<Component> { motherBoard2, graphicCard2, ram2 });
        Console.WriteLine(pc2);
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------------");
        Component motherBoard3 = new Component("ASROCK Z87 PRO4 BULK", "Game Station", (decimal)217.00);
        Component graphicCard3 = new Component("SAPPHIRE R9 270 2G GDDR5 OC", (decimal)358.00);
        Component ram3 = new Component("2x4GB DDR3 1600 MHz", (decimal)148.00);
        Computer pc3 = new Computer("Game Machine New", new List<Component> { motherBoard3, graphicCard3, ram3 });
        Console.WriteLine(pc3);
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("----------------------------------------------------------------");
        List<Computer> computers = new List<Computer>() { pc1, pc2, pc3 };
        computers.OrderByDescending(computer => computer.Price).ToList().ForEach(computer => Console.WriteLine(computer.ToString()));

    }
}
