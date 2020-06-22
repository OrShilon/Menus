using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Test temp = new Test();
            MainMenu mainMenu = new MainMenu("Main Menu Title!!");

            mainMenu.ListOfItems.AddMenuNode(new SubMenu("first SubMenu"));
            mainMenu.ListOfItems.AddMenuNode(new SubMenu("Second SubMenu"));
            mainMenu.ListOfItems.AddMenuNode(new ActionItem("First action", temp));
            mainMenu.ListOfItems.AddMenuNode(new ActionItem("First action", temp));
            mainMenu.ListOfItems.AddMenuNode(new SubMenu("Third SubMenu"));
            mainMenu.ListOfItems.AddMenuNode(new ActionItem("Second action", temp));

            SubMenu chosenSub = mainMenu.ListOfItems.MenuNodes[1] as SubMenu;
            chosenSub.AddMenuNode(new SubMenu("New first subMenu!!!"));
            chosenSub.AddMenuNode(new SubMenu("New Second subMenu!!!"));
            chosenSub.AddMenuNode(new ActionItem("New First Action Item!!!", temp));
            chosenSub.AddMenuNode(new SubMenu("New Forth subMenu!!!"));

            mainMenu.Show();
        }
    }

    class Test : IExecuteAction
    {
        public void Execute()
        {
            Console.WriteLine("Got here (action button worked)");
        }
    }
}
