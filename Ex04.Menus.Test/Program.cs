using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            string title = "Hello! This is the main menu:";
            Delegates.MainMenu mainMenu = new Delegates.MainMenu(title);

            mainMenu.Show();
        }
    }
}
