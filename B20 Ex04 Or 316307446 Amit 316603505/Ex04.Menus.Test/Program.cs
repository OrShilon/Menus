using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildAndRunInterface();
            BuildAndRunDelegate();
        }

        private static void BuildAndRunInterface()
        {
            Interfaces.MainMenu interfaceMainMenu = new Interfaces.MainMenu("Interface Main Menu Title!");
            Interfaces.SubMenu firstSubMenu = new Interfaces.SubMenu("Version and Capitals");
            Interfaces.SubMenu secondSubMenu = new Interfaces.SubMenu("Show Date/Time");

            Interfaces.ActionNode countCapitals = new Interfaces.ActionNode("Count Capitals", new InterfaceMethods.CountCapitals());
            Interfaces.ActionNode showVersion = new Interfaces.ActionNode("Show Version", new InterfaceMethods.ShowVersion());
            Interfaces.ActionNode showTime = new Interfaces.ActionNode("Show time", new InterfaceMethods.ShowTime());
            Interfaces.ActionNode showDate = new Interfaces.ActionNode("Show Date", new InterfaceMethods.ShowDate());

            //build main menu
            interfaceMainMenu.ListOfMenuNodes.AddMenuNode(firstSubMenu);
            interfaceMainMenu.ListOfMenuNodes.AddMenuNode(secondSubMenu);

            //build version and capitals
            firstSubMenu.AddMenuNode(countCapitals);
            firstSubMenu.AddMenuNode(showVersion);

            //build show and date
            secondSubMenu.AddMenuNode(showTime);
            secondSubMenu.AddMenuNode(showDate);

            interfaceMainMenu.Show();
        }

        private static void BuildAndRunDelegate()
        {
            Delegates.MainMenu interfaceMainMenu = new Delegates.MainMenu("Delegate Main Menu Title!");
            Delegates.SubMenu firstSubMenu = new Delegates.SubMenu("Version and Capitals");
            Delegates.SubMenu secondSubMenu = new Delegates.SubMenu("Show Date/Time");

            //InterfaceMethods.CountCapitals countCapitalsInterface = new InterfaceMethods.CountCapitals();
            Delegates.ActionNode countCapitals = new Delegates.ActionNode("Count Capitals", DelegateMethods.CountCapitals);
            Delegates.ActionNode showVersion = new Delegates.ActionNode("Show Version", DelegateMethods.ShowVersion);
            Delegates.ActionNode showTime = new Delegates.ActionNode("Show time", DelegateMethods.ShowTime);
            Delegates.ActionNode showDate = new Delegates.ActionNode("Show Date", DelegateMethods.ShowDate);

            //build main menu
            interfaceMainMenu.ListOfMenuNodes.AddMenuNode(firstSubMenu);
            interfaceMainMenu.ListOfMenuNodes.AddMenuNode(secondSubMenu);

            //build version and capitals
            firstSubMenu.AddMenuNode(countCapitals);
            firstSubMenu.AddMenuNode(showVersion);

            //build show and date
            secondSubMenu.AddMenuNode(showTime);
            secondSubMenu.AddMenuNode(showDate);

            interfaceMainMenu.Show();
        }
    }
}
