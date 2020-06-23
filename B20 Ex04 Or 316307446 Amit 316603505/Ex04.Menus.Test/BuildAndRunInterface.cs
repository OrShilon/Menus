using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public static class BuildAndRunInterface
    {
        public static Interfaces.MainMenu m_InterfaceMainMenu;

        public static void Run()
        {
            m_InterfaceMainMenu = new Interfaces.MainMenu("Interface Main Menu!");
            Interfaces.SubMenu firstSubMenu = new Interfaces.SubMenu("Version and Capitals");
            Interfaces.SubMenu secondSubMenu = new Interfaces.SubMenu("Show Date/Time");

            Interfaces.ActionNode countCapitals = new Interfaces.ActionNode("Count Capitals", new Methods.CountCapitals());
            Interfaces.ActionNode showVersion = new Interfaces.ActionNode("Show Version", new Methods.ShowVersion());
            Interfaces.ActionNode showTime = new Interfaces.ActionNode("Show time", new Methods.ShowTime());
            Interfaces.ActionNode showDate = new Interfaces.ActionNode("Show Date", new Methods.ShowDate());

            // Build main menu
            m_InterfaceMainMenu.ListOfMenuNodes.AddMenuNode(firstSubMenu);
            m_InterfaceMainMenu.ListOfMenuNodes.AddMenuNode(secondSubMenu);

            // Build version and capitals
            firstSubMenu.AddMenuNode(countCapitals);
            firstSubMenu.AddMenuNode(showVersion);

            // Build show and date
            secondSubMenu.AddMenuNode(showTime);
            secondSubMenu.AddMenuNode(showDate);

            m_InterfaceMainMenu.Show();
        }
    }
}
