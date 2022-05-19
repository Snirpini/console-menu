using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public interface IChosenObserver
    {
        void Execute();
    }

    public class MenuTool : MenuItem
    {
        private IChosenObserver m_ChosenObserver;

        public MenuTool(string i_Title) : base(i_Title)
        {
        }

        public IChosenObserver ChosenObserver
        {
            set
            {
                m_ChosenObserver = value;
            }
        }

        public override void DoWhenChosen()
        {
            onChoose();
        }

        private void onChoose()
        {
            m_ChosenObserver.Execute();
        }
    }
}
