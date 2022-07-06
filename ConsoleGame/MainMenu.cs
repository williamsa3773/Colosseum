using System;

namespace ConsoleGame
{
    public class MainMenu
    {
        public static string[] mainMenu = new string[]
        {
            "1: Create a new Profile",
            "2: Load a Profile",
            "3: Exit"
        };

        public static void Menu(string[] options)
        { 
            int menuChoice = 0;
            string prompt = "Please pick an option";
            do
            {
                Input.ReadOptions(prompt, options, out menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        CheckOS.OS(CheckOS.OSChecker);
                        break;
                    case 2:
                        break;
                }
            } while (menuChoice != options.Length);
        }
    }
}
