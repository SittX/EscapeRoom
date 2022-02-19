using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EscapeRoom
{
    internal static class ConsoleText
    {

        public static void DisplayText(string text,ConsoleColor color = ConsoleColor.Gray, bool entireLine = true)
        {
            if (entireLine)
            {
                ForegroundColor = color;
                WriteLine(text);
                ResetColor();
            }
            else
            {
                ForegroundColor = color;
                Write(text);
                ResetColor();
            }
        }
    }
}
