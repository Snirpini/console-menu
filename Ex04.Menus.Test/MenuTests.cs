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
            string mainMenuTitle = "Delegates Main Menu";
            Delegates.MainMenu mainMenu = new Delegates.MainMenu(mainMenuTitle);
            Delegates.SubMenu subMenu;
            Delegates.MenuTool menuTool;

            subMenu = new Delegates.SubMenu(k_ShowDateOrTimeTitle);
            menuTool = new Delegates.MenuTool(K_ShowTimeTitle, MenuFunctions.ShowTime);
            subMenu.AddNewMenuItem(menuTool);
            menuTool = new Delegates.MenuTool(K_ShowDateTitle, MenuFunctions.ShowDate);
            subMenu.AddNewMenuItem(menuTool);
            mainMenu.AddNewMenuItem(subMenu);

            subMenu = new Delegates.SubMenu(K_VersionAndSpacesTitle);
            menuTool = new Delegates.MenuTool(K_CountSpacesTitle, MenuFunctions.CountSpaces);
            subMenu.AddNewMenuItem(menuTool);
            menuTool = new Delegates.MenuTool(K_ShowVersionTitle, MenuFunctions.ShowVersion);
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
            string mainMenuTitle = "Interfaces Main Menu";
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu(mainMenuTitle);
            Interfaces.SubMenu subMenu;
            Interfaces.MenuTool menuTool;
            Interfaces.IMenuToolChosenObserver menuToolChosenObserver;

            subMenu = new Interfaces.SubMenu(k_ShowDateOrTimeTitle);
            menuToolChosenObserver = new MenuFunctionsInterfaces.ShowTime() as Interfaces.IMenuToolChosenObserver;
            menuTool = new Interfaces.MenuTool(K_ShowTimeTitle, menuToolChosenObserver);
            subMenu.AddNewMenuItem(menuTool);
            menuToolChosenObserver = new MenuFunctionsInterfaces.ShowDate() as Interfaces.IMenuToolChosenObserver;
            menuTool = new Interfaces.MenuTool(K_ShowDateTitle, menuToolChosenObserver);
            subMenu.AddNewMenuItem(menuTool);
            mainMenu.AddNewMenuItem(subMenu);

            subMenu = new Interfaces.SubMenu(K_VersionAndSpacesTitle);
            menuToolChosenObserver = new MenuFunctionsInterfaces.CountSpaces() as Interfaces.IMenuToolChosenObserver;
            menuTool = new Interfaces.MenuTool(K_CountSpacesTitle, menuToolChosenObserver);
            subMenu.AddNewMenuItem(menuTool);
            menuToolChosenObserver = new MenuFunctionsInterfaces.ShowVersion() as Interfaces.IMenuToolChosenObserver;
            menuTool = new Interfaces.MenuTool(K_ShowVersionTitle, menuToolChosenObserver);
            subMenu.AddNewMenuItem(menuTool);
            mainMenu.AddNewMenuItem(subMenu);

            return mainMenu;
        }
    }
}