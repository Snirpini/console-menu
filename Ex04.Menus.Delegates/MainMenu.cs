using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : SubMenu
    {
        public MainMenu(string i_Title) : base(i_Title) 
        {
            r_MenuItems[0].Title = "Exit";
        }
    }
}