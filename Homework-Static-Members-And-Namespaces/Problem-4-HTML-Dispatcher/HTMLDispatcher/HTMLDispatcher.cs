using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_HTML_Dispatcher
{
    public static class HTMLDispatcher
    {
        public static string CreateImage(string src, string alt, string title)
        {
            ElementBuilder img = new ElementBuilder("img");
            img.AddAttr("src", src);
            img.AddAttr("alt", alt);
            img.AddAttr("title", title);
            img.IsClosingTag(false);
            return img.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder a = new ElementBuilder("a");
            a.AddAttr("href", url);
            a.AddAttr("title", title);
            a.AddContent(text);
            a.IsClosingTag(true);
            return a.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.AddAttr("type", type);
            input.AddAttr("name", name);
            input.AddAttr("value", value);
            input.IsClosingTag(false);
            return input.ToString();
        }
    }
}
