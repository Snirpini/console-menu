﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem, IChosenObserver
    {
        protected List<MenuItem> m_MenuItems = new List<MenuItem>();
        private bool m_Exit = false;

        public SubMenu(string i_Title) : base(i_Title)
        {
            MenuTool menuTool = new MenuTool("Back");
            menuTool.ChosenObserver = this as IChosenObserver;
            AddNewMenuItem(menuTool);
        }

        public bool Exit
        {
            set
            {
                m_Exit = value;
            }
        }

        public void AddNewMenuItem(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        public void Show()
        {
            while (!m_Exit)
            {
                printMenu();
                int userChoice = getUserChoice();

                Console.Clear();
                m_MenuItems[userChoice].DoWhenChosen();

                if (m_MenuItems[userChoice] is MenuTool && userChoice != 0)
                {
                    Console.WriteLine("{0}Press any key to back to last menu...", Environment.NewLine);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        private void printMenu()
        {
            Console.WriteLine(Title);

            for (int i = 1; i < m_MenuItems.Count; i++)
            {
                Console.WriteLine(i.ToString() + " -> " + m_MenuItems[i].Title);
            }

            Console.WriteLine("0 -> " + m_MenuItems[0].Title);
        }

        private int getUserChoice()
        {
            string userInput;
            bool isValidInput;

            do
            {
                userInput = Console.ReadLine();
                if (!(isValidInput = checkIsValidInput(userInput)))
                {
                    Console.WriteLine("Invalid input! please try again.");
                }
            } while (!isValidInput);

            return int.Parse(userInput);
        }

        private bool checkIsValidInput(string i_Input)
        {
            int userChoice;

            return int.TryParse(i_Input, out userChoice) && userChoice >= 0 && userChoice < m_MenuItems.Count;
        }

        private void doWhenExit()
        {
            m_Exit = true;
        }

        public override void DoWhenChosen()
        {
            this.Show();
        }

        void IChosenObserver.Execute()
        {
            doWhenExit();
        }
    }
}