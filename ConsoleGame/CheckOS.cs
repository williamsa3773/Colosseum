using System;
using System.IO;

namespace ConsoleGame
{
    public class CheckOS
    {
        //checking for only windows and mac at the moment;
        public static string[] OSChecker = new string[]
        {
            "1: Windows",
            "2: Mac",
            "3: Exit"
        };

        public static void OS(string[] options)
        {
            int osChoice = 0;
            string prompt = "Please choose the current OS you are configuring files for!";

            do
            {
                Input.ReadOptions(prompt, options, out osChoice);
                switch (osChoice)
                {
                    case 1:
                        FolderExist();
                        break;
                    case 2:
                        FolderExist();
                        break;
                }
            } while (osChoice != options.Length);
        }

        
        public static void FolderExist()
        {
            Console.WriteLine("What is the username for your computer?");
            string folderName = Console.ReadLine();
            string path = $"/users/{folderName}/Colosseum";
           
            if (Directory.Exists(path))
            {
                Console.WriteLine("It exists\n");
                
            } else
            {
                Console.WriteLine("Folder does not currently exist");
                Directory.CreateDirectory(path);
                Console.WriteLine("~~~~~Created~~~~~\n");
            }
        }
    }
}
