using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu interfaceMainMenu = new Interfaces.MainMenu("Main Menu Title!");
            SubMenu firstSubMenu = new SubMenu("Version and Capitals");
            SubMenu secondSubMenu = new SubMenu("Show Date/Time");

            InterfaceMethods.CountCapitals countCapitalsInterface = new InterfaceMethods.CountCapitals();
            ActionItem countCapitals = new ActionItem("Count Capitals", countCapitalsInterface);
            InterfaceMethods.ShowVersion showVersionInterface = new InterfaceMethods.ShowVersion();
            ActionItem showVersion = new ActionItem("Show Version", showVersionInterface);
            InterfaceMethods.ShowTime showTimeInterface = new InterfaceMethods.ShowTime();
            ActionItem showTime = new ActionItem("Show time", showTimeInterface);
            InterfaceMethods.ShowDate showDateInterface = new InterfaceMethods.ShowDate();
            ActionItem showDate = new ActionItem("Show Date", showDateInterface);

            //build main menu
            interfaceMainMenu.ListOfItems.AddMenuNode(firstSubMenu);
            interfaceMainMenu.ListOfItems.AddMenuNode(secondSubMenu);

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
