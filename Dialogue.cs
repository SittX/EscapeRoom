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
            GrayText($"\n{breakingMessage}\n",false);
            ReadKey();
        }
        public static void IntroMessage()
        {
            RedText(GameTitle,false);
           GrayText("\tWelcome from 'Devils Between' game, stranger");
        }

        public static void StoryBeginning(Player currentPlayer)
        {
            string player = currentPlayer.Playername;
            string nameSuffix;
            if (currentPlayer.Gender == "M")
            {
                nameSuffix = "Mr";
            }
            else
            {
                nameSuffix = "Ms";
            }
            BreakDialogue("\nPress any key to start");
            GrayText("\n================================================================================");
            Clear();
            RedText(House);
            RedText("\nOn a heavily raining night, someone is knocking your front door.");
            BreakDialogue("Press any key to open the door");
            Clear();
            RedText(Officer);
            BlueText($"\nThe police Officer :  Are you {nameSuffix} {player} ?");
            BreakDialogue("Press any key to answer the question");
            GreenText($"\n{player} : Yes, I'm {player}.");
            BlueText("\nThe police Officer : Sir there is a murder case at Downin street and the chief said that he wants you to come and see the case.");
            GreenText($"\n{player} : Alright,I'll be there in a minute. Let's me take my coat first.");
            BreakDialogue("Press any key to continue");
            GrayText("\n================================================================================");
            Clear();
        }

        public static void Scene1Dialogue()
        {
            RedText(CrimeScene1);
            GrayText("\nWhen you reached to the crime scene, you found many polices searching the evidences all over the place.");
            GrayText("\nThe victim, a young man in his 20s, is hanged on a bar between the two buildings.");
            GrayText("\nOne policeman approached to you and said ");
            BlueText("The Policeman : Looks like another suicide case but it's strange how he did climb up between those buildings.");
            BreakDialogue("\nPress any key to ask for evidences");
            Clear();
            GreenText("\nYou : Is there any evidences related to the victim ?");
            BlueText("\nThe policeman : These isn't alot yet but we have found these ");
        }

        public static void Scene2Dialogue()
        {
        }
    }
}
