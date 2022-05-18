using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    public static class MenuFunctions
    {
        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Today.Date.ToString());      
        }

        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
        }

        public static void CountSpaces()
        {
            Console.WriteLine("Please enter a sentence:");
            string sentence = Console.ReadLine();
            int counter = 0;

            foreach(char ch in sentence)
            {
                if(char.IsWhiteSpace(ch))
                {
                    counter++;
                }
            }

            Console.WriteLine("There are {0} whitespaces in this sentence.", counter);
        }

        public static void ShowVersion()
        {
            Console.WriteLine("Version: 21.1.4.8930");
        }
    }
}
