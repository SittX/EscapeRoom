using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    internal class Door
    {
        private string _description;
        public string Description { get; set; }
        public Door(string description)
        {
            _description = description;
        }
    }
}
