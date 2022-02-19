using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static EscapeRoom.ConsoleText;
using static EscapeRoom.AsciiArt;
namespace EscapeRoom
{
    internal static class Dialogue
    {
       
        private static void BreakDialogue(string breakingMessage)
        {
            DisplayText($"\n{breakingMessage}\n",ConsoleColor.Gray,false);
            ReadKey();
        }
        public static void IntroMessage()
        {
            DisplayText(GameTitle, ConsoleColor.DarkRed, false);
           DisplayText("\tWelcome from 'Devils Between' game, stranger");
        }

        public static void StoryBeginning(Player currentPlayer)
        {
            string playername = currentPlayer.Playername;
            string namePrefix;
            if (currentPlayer.Gender == "M")
            {
                namePrefix = "Mr";
            }
            else
            {
                namePrefix = "Ms";
            }
            BreakDialogue("\nPress any key to start");
            DisplayText("\n================================================================================");
            Clear();
            DisplayText(House,ConsoleColor.DarkRed);
            DisplayText("\nOn a heavily raining night, someone is knocking your front door.");
            BreakDialogue("Press any key to open the door");
            Clear();
            DisplayText(Officer,ConsoleColor.Blue);
            DisplayText($"\nThe police Officer :  Are you {namePrefix} {playername} ?",ConsoleColor.Blue);
            BreakDialogue("Press any key to answer the question");
            DisplayText($"\n{playername} : Yes, I'm {playername}.",ConsoleColor.Green);
            DisplayText("\nThe police Officer : Sir there is a murder case at Downin street and the chief said that he wants you to come and see the case.",ConsoleColor.Blue);
            DisplayText($"\n{playername} : Alright,I'll be there in a minute. Let's me take my coat first.",ConsoleColor.Green);
            BreakDialogue("Press any key to continue");
            DisplayText("\n================================================================================");
            Clear();
        }

        public static void Scene1Dialogue()
        {
            DisplayText(CrimeScene1,ConsoleColor.DarkRed);
            DisplayText("\nWhen you reached to the crime scene, you found many polices searching the evidences all over the place.");
            DisplayText("\nThe victim, a young man in his 20s, is hanged on a bar between the two buildings.");
            DisplayText("\nOne policeman approached to you and said ");
            DisplayText("The Policeman : Looks like another suicide case but it's strange how he did climb up between those buildings.",ConsoleColor.Blue);
            BreakDialogue("\nPress any key to ask for evidences");
            Clear();
            DisplayText("\nYou : Is there any evidences related to the victim ?",ConsoleColor.Green);
            DisplayText("\nThe policeman : These isn't alot yet but we have found these ",ConsoleColor.Blue);
        }

        public static void Scene2Dialogue()
        {
        }
    }
}
