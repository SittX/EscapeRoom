﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Import some static class. So, I don't have to add prefixes to the every beginning of the methods from those classes.
using static System.Console;
using static EscapeRoom.Dialogue;
using static EscapeRoom.ConsoleText;


namespace EscapeRoom
{
    internal class Game
    {
        private CrimeScene _Scene1, _Scene2, _Scene3;
        private Door door1, door2, door3;
        private Player _CurrentPlayer;
        private List<Item> items;
        public Game()
        {
            // Scene 1
            Item steelRod = new Item("(1) A steel rod with blood on the handle","The killer might used this stick to kill the victim.\nBut there is no beaten wound on the victim body.");
            Item glass = new Item("(2) An broken pair of glasses","A broken pair of glasses with some blood on the side of the glass.");
            items = new List<Item>{ steelRod, glass };
            door1 = new Door("(3) A wooden door with a broken handle.");
            _Scene1 = new CrimeScene(items,door1);

            //Scene 2
            
        }

        public void Run()
        {
            // TODO : ALl the game logics go here
            IntroMessage();
            GetUserInfo();
            StoryBeginning(_CurrentPlayer);
            FirstScene();
            SecondScene();
        }



        private void GetUserInfo()
        {
            string username;
            string gender;
            // Use try-catch to handle exceptions
            try
            {
                while (true)
                {
                DisplayText("\n======================================================");
                DisplayText("\nName : ",ConsoleColor.Gray, false);
                username = ReadLine();
                DisplayText("\nGender [ M/F ] : ",ConsoleColor.Gray, false);
                gender = ReadLine().ToUpper();

                    if(gender == "M" || gender == "F")
                    {
                        _CurrentPlayer = new Player(username, gender);
                        break;
                    }else
                    {
                        DisplayText("\nPlease choose your gender.",ConsoleColor.Red);
                    }
                DisplayText("\n======================================================");
                }
            }
            catch (Exception ex)
            {
                DisplayText(ex.Message,ConsoleColor.Red);
                throw;
            }

        }

        private void Description(Item item)
        {
            Console.Clear();
            Console.WriteLine("\n");
            DisplayText(">>>Item description ");
            DisplayText("\n" + item.Description,ConsoleColor.Red);
        }

        private void FirstScene()
        {

            bool exitLoop = false;
            Scene1Dialogue();
            while (!exitLoop)
            {
            _Scene1.DisplayEvidences();
            DisplayText("\nChoose an item to closely investigate ",ConsoleColor.Gray,false);
            string item = ReadLine().ToLower();
            switch (item)
            {
                case "1":
                    items[0].DisplayItemDescription();
                    break;
                case "2":
                    items[1].DisplayItemDescription();
                    break;
                case "3":
                    WriteLine("You passed through the wooden door.....");
                     exitLoop= true;
                    break;
                default:
                    break;
            }
            }
            Console.WriteLine("To be continue...");
        }

        private void SecondScene()
        {
        }
    }
}
