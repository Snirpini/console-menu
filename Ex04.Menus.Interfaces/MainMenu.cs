using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : SubMenu
    {
        public MainMenu(string i_Title) : base(i_Title)
        {
            m_MenuItems[0].Title = "Exit";
        }
    }
}
