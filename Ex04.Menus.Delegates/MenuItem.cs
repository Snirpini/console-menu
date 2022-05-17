using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private readonly string r_Title;
        public event Action<string> m_Report

        public MenuItem(string i_Title)
        {
            r_Title = i_Title;
        }

        
    }
}
