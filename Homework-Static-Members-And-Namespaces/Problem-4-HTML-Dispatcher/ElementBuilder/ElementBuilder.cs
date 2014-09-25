using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_HTML_Dispatcher
{
    public class ElementBuilder
    {
        private string name;
        private string content = "";
        private bool isClosingTag = false;
        private Dictionary<string, string> attributes = new Dictionary<string,string>();

        //property for Name
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

        //Constructor
        public ElementBuilder(string name)
        {
            this.Name = name;
        }

        //Public Method for Adding a attribute
        public void AddAttr(string name, string value)
        {
            this.attributes.Add(name, value);
        }

        //Public Method for Adding Content
        public void AddContent(string content)
        {
            this.content = content;
        }

        //Public Method to determinate if the html tag has closing tag or it's closing self
        public void IsClosingTag(bool isClosingTag)
        {
            this.isClosingTag = isClosingTag;
        }

        //Public Override to String Method for ElementBuilder Class
        public override string ToString()
        {
            string strAttr = "";
            foreach (var attribute in attributes)
            {
                strAttr += " " + attribute.Key + "=\"" + attribute.Value + "\"";
            }

            string result = "";
            if (this.isClosingTag)
            {
                result = String.Format("<{0}{1}>{2}</{0}>", this.name, strAttr, this.content);
            }
            else 
            {
                result = String.Format("<{0}{1} />", this.name, strAttr);
            }
            return result;
        }

        //Public Static Method for overloading the Multiply Operator to create several html tags
        public static string operator *(ElementBuilder element, int n)
        {
            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += element.ToString();
            }

            return result;
        }
    }
}
