using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        protected readonly List<MenuItem> r_MenuItems = new List<MenuItem>();
        private bool m_Exit;

        public SubMenu(string i_Title) : base(i_Title)
        {
            MenuTool menuTool = new MenuTool("Back", this.doWhenExit);
            AddNewMenuItem(menuTool);
        }

        public void AddNewMenuItem(MenuItem i_MenuItem)
        {
            r_MenuItems.Add(i_MenuItem);
        }

        public void Show()
        {
            m_Exit = false;
            int userChoice;

            while (!m_Exit)
            {
                printMenu();
                userChoice = getUserChoice();
                Console.Clear();
                r_MenuItems[userChoice].DoWhenChosen();
                if (r_MenuItems[userChoice] is MenuTool && userChoice != 0)
                {
                    Console.WriteLine("{0}Press any key to back to last menu...", Environment.NewLine);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        private void printMenu()
        {
            Console.WriteLine($"**{Title}**");
            printSeparator();
            for (int i = 1; i < r_MenuItems.Count; i++)
            {
                Console.WriteLine("{0}) {1}", i.ToString(), r_MenuItems[i].Title);
            }
            Console.WriteLine("0) {0}", r_MenuItems[0].Title);
            printSeparator();
            Console.WriteLine("Enter your requst: (1 to {0} or press '0' to {1})", r_MenuItems.Count - 1, r_MenuItems[0].Title);
        }

        private void printSeparator()
        {
            Console.WriteLine("========================");
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
            } while(!isValidInput);

            return int.Parse(userInput);
        }

        private bool checkIsValidInput(string i_Input)
        {
            int userChoice;

            return int.TryParse(i_Input, out userChoice) && userChoice >= 0 && userChoice < r_MenuItems.Count;
        }

        private void doWhenExit()
        {
            m_Exit = true;
        }

        internal override void DoWhenChosen()
        {
            this.Show();
        }
    }
}