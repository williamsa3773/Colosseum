using System;
namespace ConsoleGame
{
    public class Input
    {
        //read the numbers users input for the various menus
        public static int ReadNumber(string prompt, int min, int max)
        {
            int data;
            string input;
            do
            {
                input = Console.ReadLine();
                try
                {
                    Int32.TryParse(input, out data);
                    if(data >= min || data <= max)
                    {
                        break;
                    }
                } catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            } while (true);
            Console.WriteLine();
            return data;
        }
 
        public static void ReadOptions(string prompt, string[] options, out int selection)
        {
            Console.WriteLine(prompt);
            for (int i=0; i<options.Length; i++)
            {
                Console.WriteLine(options[i]);
            }
            Console.WriteLine();
            selection = ReadNumber(prompt, 1, options.Length);
        }

        public static void ReadString(string prompt, ref string value)
        {
            do
            {
                if (String.IsNullOrEmpty(value))
                    Console.WriteLine(prompt);
            } while (true);
        }

    }
}
