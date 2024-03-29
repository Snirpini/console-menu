﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    public static class MenuFunctions
    {
        public static void ShowDate()
        {
            Console.WriteLine("The Date is: {0}", DateTime.Now.ToString("dd/MM/yyyy"));
        }

        public static void ShowTime()
        {
            Console.WriteLine("The Time is: {0}", DateTime.Now.ToString("HH:mm:ss"));
        }

        public static void CountSpaces()
        {
            Console.WriteLine("Please enter a sentence:");
            string sentence = Console.ReadLine();
            int numOfSpaces = 0;
            foreach(char ch in sentence)
            {
                if(char.IsWhiteSpace(ch))
                {
                    numOfSpaces++;
                }
            }
            Console.WriteLine("There are {0} whitespaces in this sentence.", numOfSpaces);
        }

        public static void ShowVersion()
        {
            string version = "21.1.4.8930";
            Console.WriteLine("Version: {0}", version);
        }
    }
}