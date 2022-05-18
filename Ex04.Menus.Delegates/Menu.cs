using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class Menu : MenuItem
    {
        protected List<MenuItem> m_MenuItems = new List<MenuItem>();

        public Menu(string i_Title) : base(i_Title)
        {

        }

        public void AddMenuItem(MenuItem menuItem)
        {

        }

        // public void RemoveMenuItem() ?
    }
}
