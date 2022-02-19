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

        public static void RedText(string text, bool entireLine = true)
        {
            if (entireLine)
            {
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine(text);
                ResetColor();
            }
            else
            {
                ForegroundColor = ConsoleColor.DarkRed;
                Write(text);
                ResetColor();
            }
        }

        public static void BlueText(string text, bool entireLine = true)
        {
            if (entireLine)
            {
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine(text);
                ResetColor();
            }
            else
            {
                ForegroundColor = ConsoleColor.DarkCyan;
                Write(text);
                ResetColor();
            }
        }

        public static void GreenText(string text, bool entireLine = true)
        {
            if (entireLine)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(text);
                ResetColor();
            }
            else
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                Write(text);
                ResetColor();
            }
        }

        public static void GrayText(string text, bool entireLine = true)
        {
            if (entireLine)
            {
                ForegroundColor = ConsoleColor.Gray;
                WriteLine(text);
                ResetColor();
            }
            else
            {
                ForegroundColor = ConsoleColor.Gray;
                Write(text);
                ResetColor();
            }
        }
    }
}
