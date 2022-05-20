using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    public static class MenuFunctionsInterfaces
    {
        public class ShowDate : Interfaces.IMenuToolChosenObserver
        {
            void Interfaces.IMenuToolChosenObserver.Execute()
            {
                MenuFunctions.ShowDate();
            }
        }

        public class ShowTime : Interfaces.IMenuToolChosenObserver
        {
            void Interfaces.IMenuToolChosenObserver.Execute()
            {
                MenuFunctions.ShowTime();
            }
        }

        public class CountSpaces : Interfaces.IMenuToolChosenObserver
        {
            void Interfaces.IMenuToolChosenObserver.Execute()
            {
                MenuFunctions.CountSpaces();
            }
        }

        public class ShowVersion : Interfaces.IMenuToolChosenObserver
        {
            void Interfaces.IMenuToolChosenObserver.Execute()
            {
                MenuFunctions.ShowVersion();
            }
        }
    }
}