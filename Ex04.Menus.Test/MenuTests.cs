using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Ex04.Menus.Delegates;

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
            MainMenu mainMenu =  DelegatesInitMenu();
            mainMenu.Show();
        }

        private MainMenu DelegatesInitMenu()
        {
            string title = "**Delegates Main Menu**";
            MainMenu mainMenu = new MainMenu(title);
            SubMenu subMenu;
            MenuTool menuTool;

            subMenu = new SubMenu(k_ShowDateOrTimeTitle);
            menuTool = new MenuTool(K_ShowTimeTitle);
            menuTool.m_ReportChosenDelegate += MenuFunctions.ShowTime;
            subMenu.AddNewMenuItem(menuTool);
            menuTool = new MenuTool(K_ShowDateTitle);
            menuTool.m_ReportChosenDelegate += MenuFunctions.ShowDate;
            subMenu.AddNewMenuItem(menuTool);
            mainMenu.AddNewMenuItem(subMenu);

            subMenu = new SubMenu(K_VersionAndSpacesTitle);
            menuTool = new MenuTool(K_CountSpacesTitle);
            menuTool.m_ReportChosenDelegate += MenuFunctions.CountSpaces;
            subMenu.AddNewMenuItem(menuTool);
            menuTool = new MenuTool(K_ShowVersionTitle);
            menuTool.m_ReportChosenDelegate += MenuFunctions.ShowVersion;
            subMenu.AddNewMenuItem(menuTool);
            mainMenu.AddNewMenuItem(subMenu);

            return mainMenu;
        }

    }
}
