using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EscapeRoom.Dialogue;
using static EscapeRoom.ConsoleText;
namespace EscapeRoom
{
    internal class Item
    {
        // Private fields
        private  string _name ,_description;

        // Properties for the fields
        public string Name { get; set; }
        public string Description { get; set; }

        // Constructor method
        public Item(string name,string description)
        {
            Name = name;
            Description = description;
        }

        public void DisplayItem()
        {
            DisplayText("\n"+Name);
        }

        public void DisplayItemDescription()
        {
            Console.Clear();
            Console.WriteLine("\n");
            DisplayText(">>>Item description ");
            DisplayText("\n"+Description,ConsoleColor.Red);
        }
    }
}
