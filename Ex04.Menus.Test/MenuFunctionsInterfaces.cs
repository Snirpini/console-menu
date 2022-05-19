using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    public static class MenuFunctionsInterfaces
    {
        public class ShowDate : Interfaces.IChosenObserver
        {
            void Interfaces.IChosenObserver.Execute()
            {
                MenuFunctions.ShowDate();
            }
        }

        public class ShowTime : Interfaces.IChosenObserver
        {
            void Interfaces.IChosenObserver.Execute()
            {
                MenuFunctions.ShowTime();
            }
        }

        public class CountSpaces : Interfaces.IChosenObserver
        {
            void Interfaces.IChosenObserver.Execute()
            {
                MenuFunctions.CountSpaces();
            }
        }

        public class ShowVersion : Interfaces.IChosenObserver
        {
            void Interfaces.IChosenObserver.Execute()
            {
                MenuFunctions.ShowVersion();
            }
        }
    }
}
