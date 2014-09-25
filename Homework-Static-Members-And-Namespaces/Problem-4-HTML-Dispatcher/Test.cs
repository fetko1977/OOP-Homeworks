using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_HTML_Dispatcher
{
    class Test
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttr("id", "main");
            div.AddAttr("class", "left");
            div.AddContent("<p>This is my left div</p>");
            div.IsClosingTag(true);
            Console.WriteLine(div);
            Console.WriteLine(div * 2);
            Console.WriteLine();

            Console.WriteLine(HTMLDispatcher.CreateImage("fetko1977.jpg", "Svetoslav Savov", "Svetoslav Savov"));
            Console.WriteLine(HTMLDispatcher.CreateInput("text", "username", "fetko1977"));
            Console.WriteLine(HTMLDispatcher.CreateURL("http://www.softuni.bg", "Softuni", "Software University of Bulgaria"));
        }
    }
}
