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

            mainMenu.ListOfMenuNodes.AddMenuNode(new SubMenu("first SubMenu"));
            mainMenu.ListOfMenuNodes.AddMenuNode(new SubMenu("Second SubMenu"));
            mainMenu.ListOfMenuNodes.AddMenuNode(new ActionNode("First action", temp));
            mainMenu.ListOfMenuNodes.AddMenuNode(new ActionNode("First action", temp));
            mainMenu.ListOfMenuNodes.AddMenuNode(new SubMenu("Third SubMenu"));
            mainMenu.ListOfMenuNodes.AddMenuNode(new ActionNode("Second action", temp));

            SubMenu chosenSub = mainMenu.ListOfMenuNodes.MenuNodes[1] as SubMenu;
            chosenSub.AddMenuNode(new SubMenu("New first subMenu!!!"));
            chosenSub.AddMenuNode(new SubMenu("New Second subMenu!!!"));
            chosenSub.AddMenuNode(new ActionNode("New First Action Item!!!", temp));
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
