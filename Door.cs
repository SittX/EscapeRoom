using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    internal class Door
    {
        public string Description { get; private set; }
        public Door(string description)
        {
            Description = description;
        }
    }
}
