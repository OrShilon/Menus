using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public static class UserInteraction
    {
        private const string m_ExitMessage = "Exit";
        private const string m_BackMessage = "Back";

        private static void PrintMenu(SubMenu i_Menu)
        {
            int index = 1;

            Console.Clear();
            Console.WriteLine(i_Menu.Title + Environment.NewLine);
            foreach (MenuNode item in i_Menu.MenuNodes)
            {
                Console.WriteLine("{0}. {1}", index, item.Title);
                index++;
            }

            Console.WriteLine("0. {0}", i_Menu.ParentMenu == null ? m_ExitMessage : m_BackMessage);
            Console.WriteLine("Please Choose the coresponding number to the button you want to choose");
        }

        public static int DisplayMenuAndCheckUserInput(SubMenu i_Menu)
        {
            string userInput;
            int validInput;

            PrintMenu(i_Menu);
            userInput = Console.ReadLine();
            while(!isValidMenuOption(userInput, out validInput))
            {
                Console.WriteLine("Invalid Input.");
                PrintMenu(i_Menu);
                userInput = Console.ReadLine();
            }

            return validInput;
        }

        private static bool isValidMenuOption(string i_UserInput, out int o_ValidInput)
        {
            return int.TryParse(i_UserInput, out o_ValidInput) && o_ValidInput >= 0; //need to change 0 to const
        }





        public static void PressAnyKetToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
