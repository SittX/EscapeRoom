using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    internal class Player
    {
        public string Playername { get; set; }
        public string Gender { get; set; }

        public Player(string playername,string gender)
        {
            Playername = playername;
            Gender = gender;
        }
    }
}
