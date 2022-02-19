using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game();
            myGame.Run();
            Console.ReadLine();
        }
    }
}
