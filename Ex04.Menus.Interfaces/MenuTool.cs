using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public interface IMenuToolChosenObserver
    {
        void Execute();
    }

    public class MenuTool : MenuItem
    {
        private readonly IMenuToolChosenObserver r_ChosenObserver;

        public MenuTool(string i_Title, IMenuToolChosenObserver i_ChosenObserver) : base(i_Title)
        {
            r_ChosenObserver = i_ChosenObserver;
        }

        internal override void DoWhenChosen()
        {
            onChoose();
        }

        private void onChoose()
        {
            r_ChosenObserver.Execute();
        }
    }
}