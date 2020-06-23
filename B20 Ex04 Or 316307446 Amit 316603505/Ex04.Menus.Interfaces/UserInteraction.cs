using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public static class UserInteraction
    {
        private const string k_ExitMessage = "Exit";
        private const string k_BackMessage = "Back";
        private const string k_BackToPreviousMenuMessage = "to go back to the previous menu";
        private const int k_ExitOrBack = 0;
        private const int k_MenuOffset = 1;

        private static void printMenu(SubMenu i_Menu)
        {
            int index = 1;

            Console.Clear();
            Console.WriteLine(i_Menu.Title + Environment.NewLine);
            foreach (MenuNode item in i_Menu.MenuNodes)
            {
                Console.WriteLine("{0}. {1}", index, item.Title);
                index++;
            }

            Console.WriteLine("0. {0}", i_Menu.ParentMenu == null ? k_ExitMessage : k_BackMessage);
            Console.WriteLine("Please Choose the appropriate menu option, or 0 to {0}.", i_Menu.ParentMenu == null ? k_ExitMessage : k_BackToPreviousMenuMessage);
        }

        private static int printManager(SubMenu i_Menu)
        {
            string userInput;
            int validInput;

            printMenu(i_Menu);
            userInput = Console.ReadLine();
            while(!isValidMenuOption(userInput, i_Menu.MenuNodes.Count, out validInput))
            {
                Console.WriteLine("Invalid Input. Return to menu options.");
                Thread.Sleep(2000);
                printMenu(i_Menu);
                userInput = Console.ReadLine();
            }

            return validInput;
        }

        public static void Show(SubMenu i_Menu)
        {
            int userChoice = -1;

            while (!userChoice.Equals(k_ExitOrBack))
            {
                userChoice = UserInteraction.printManager(i_Menu);

                if (!userChoice.Equals(k_ExitOrBack))
                {
                    i_Menu.MenuNodes[userChoice - k_MenuOffset].DoWhenClicked();
                }
            }
        }

        private static bool isValidMenuOption(string i_UserInput, int i_MenuLength, out int o_ValidInput)
        {
            return int.TryParse(i_UserInput, out o_ValidInput) && o_ValidInput >= k_ExitOrBack && o_ValidInput <= i_MenuLength; 
        }

        public static void PressAnyKetToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
