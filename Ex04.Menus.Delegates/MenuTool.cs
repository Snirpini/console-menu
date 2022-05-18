using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MenuTool : MenuItem
    {
        public event Action m_ReportChosenDelegate;
        public MenuTool(string i_Title) : base(i_Title)
        {
        }

        public override void DoWhenChosen()
        {
            onChoose();
        }

        private void onChoose()
        {
            if (m_ReportChosenDelegate != null)
            {
                m_ReportChosenDelegate.Invoke();
            }
        }
    }
}
