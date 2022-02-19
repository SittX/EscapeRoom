using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static EscapeRoom.ConsoleText;
namespace EscapeRoom
{
    internal class CrimeScene
    {
        private List<Item> _items;
        private string _door;
        public CrimeScene(List<Item> items, Door door)
        {
            _items = items;
            _door = door.Description;
        }

        // Display evidences related to each crime scene
        // * Might change according to the different scene
        public void DisplayEvidences()
        {
            GrayText("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in _items)
            {
                item.DisplayItem();
            }
            GrayText("\n"+_door);
            GrayText("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
