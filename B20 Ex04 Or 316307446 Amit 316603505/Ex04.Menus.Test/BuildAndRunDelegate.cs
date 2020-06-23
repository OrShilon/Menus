using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class BuildAndRunDelegate
    {
        public static Delegates.MainMenu m_DelegateMainMenu;

        public static void Run()
        {
            m_DelegateMainMenu = new Delegates.MainMenu("Delegate Main Menu Title!");
            Delegates.SubMenu firstSubMenu = new Delegates.SubMenu("Version and Capitals");
            Delegates.SubMenu secondSubMenu = new Delegates.SubMenu("Show Date/Time");

            Delegates.ActionNode countCapitals = new Delegates.ActionNode("Count Capitals", new Methods.CountCapitals().Execute);
            Delegates.ActionNode showVersion = new Delegates.ActionNode("Show Version", new Methods.ShowVersion().Execute);
            Delegates.ActionNode showTime = new Delegates.ActionNode("Show time", new Methods.ShowTime().Execute);
            Delegates.ActionNode showDate = new Delegates.ActionNode("Show Date", new Methods.ShowDate().Execute);

            // Build main menu
            m_DelegateMainMenu.ListOfMenuNodes.AddMenuNode(firstSubMenu);
            m_DelegateMainMenu.ListOfMenuNodes.AddMenuNode(secondSubMenu);

            // Build version and capitals
            firstSubMenu.AddMenuNode(countCapitals);
            firstSubMenu.AddMenuNode(showVersion);

            // Build show and date
            secondSubMenu.AddMenuNode(showTime);
            secondSubMenu.AddMenuNode(showDate);

            m_DelegateMainMenu.Show();
        }
    }
}
