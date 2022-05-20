using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MenuTool : MenuItem
    {
        private event Action m_MenuToolChosenDelegate;

        public MenuTool(string i_Title, Action i_MenuToolChosenDelegate) : base(i_Title)
        {
            m_MenuToolChosenDelegate += i_MenuToolChosenDelegate;
        }

        internal override void DoWhenChosen()
        {
            onChoose();
        }

        private void onChoose()
        {
            if (m_MenuToolChosenDelegate != null)
            {
                m_MenuToolChosenDelegate.Invoke();
            }
        }
    }
}