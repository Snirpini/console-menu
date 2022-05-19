using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    public class MenuTests
    {
        const string k_ShowDateOrTimeTitle = "Show Date/Time";
        const string K_ShowTimeTitle = "Show Time";
        const string K_ShowDateTitle = "Show Date";
        const string K_VersionAndSpacesTitle = "Version and Spaces";
        const string K_ShowVersionTitle = "Show Version";
        const string K_CountSpacesTitle = "Count Spaces";

        public void DelegatesMenuRun()
        {
            Delegates.MainMenu mainMenu =  DelegatesInitMenu();
            mainMenu.Show();
        }

        private Delegates.MainMenu DelegatesInitMenu()
        {
            string title = "Delegates Main Menu";
            Delegates.MainMenu mainMenu = new Delegates.MainMenu(title);
            Delegates.SubMenu subMenu;
            Delegates.MenuTool menuTool;

            subMenu = new Delegates.SubMenu(k_ShowDateOrTimeTitle);
            menuTool = new Delegates.MenuTool(K_ShowTimeTitle);
            menuTool.m_MenuToolChosenDelegate += MenuFunctions.ShowTime;
            subMenu.AddNewMenuItem(menuTool);
            menuTool = new Delegates.MenuTool(K_ShowDateTitle);
            menuTool.m_MenuToolChosenDelegate += MenuFunctions.ShowDate;
            subMenu.AddNewMenuItem(menuTool);
            mainMenu.AddNewMenuItem(subMenu);

            subMenu = new Delegates.SubMenu(K_VersionAndSpacesTitle);
            menuTool = new Delegates.MenuTool(K_CountSpacesTitle);
            menuTool.m_MenuToolChosenDelegate += MenuFunctions.CountSpaces;
            subMenu.AddNewMenuItem(menuTool);
            menuTool = new Delegates.MenuTool(K_ShowVersionTitle);
            menuTool.m_MenuToolChosenDelegate += MenuFunctions.ShowVersion;
            subMenu.AddNewMenuItem(menuTool);
            mainMenu.AddNewMenuItem(subMenu);

            return mainMenu;
        }

        public void InterfacesMenuRun()
        {
            Interfaces.MainMenu mainMenu = InterfacesInitMenu();
            mainMenu.Show();
        }

        private Interfaces.MainMenu InterfacesInitMenu()
        {
            string title = "Interfaces Main Menu";
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu(title);
            Interfaces.SubMenu subMenu;
            Interfaces.MenuTool menuTool;

            subMenu = new Interfaces.SubMenu(k_ShowDateOrTimeTitle);
            menuTool = new Interfaces.MenuTool(K_ShowTimeTitle);
            menuTool.ChosenObserver = new MenuFunctionsInterfaces.ShowTime();
            subMenu.AddNewMenuItem(menuTool);
            menuTool = new Interfaces.MenuTool(K_ShowDateTitle);
            menuTool.ChosenObserver = new MenuFunctionsInterfaces.ShowDate();
            subMenu.AddNewMenuItem(menuTool);
            mainMenu.AddNewMenuItem(subMenu);

            subMenu = new Interfaces.SubMenu(K_VersionAndSpacesTitle);
            menuTool = new Interfaces.MenuTool(K_CountSpacesTitle);
            menuTool.ChosenObserver = new MenuFunctionsInterfaces.CountSpaces();
            subMenu.AddNewMenuItem(menuTool);
            menuTool = new Interfaces.MenuTool(K_ShowVersionTitle);
            menuTool.ChosenObserver = new MenuFunctionsInterfaces.ShowVersion();
            subMenu.AddNewMenuItem(menuTool);
            mainMenu.AddNewMenuItem(subMenu);

            return mainMenu;
        }
    }
}
