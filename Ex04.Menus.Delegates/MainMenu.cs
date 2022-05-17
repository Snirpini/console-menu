using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : Menu
    {
        public MainMenu(string i_Title) : base(i_Title)
        {
        }

        public void Show()
        {
            Console.WriteLine(this.Title);

        }

        private void printMenuOptions()
        {
            for(int i = 1; i < m_MenuItems.Count; i++)
            {

            }
        }
    }
}
