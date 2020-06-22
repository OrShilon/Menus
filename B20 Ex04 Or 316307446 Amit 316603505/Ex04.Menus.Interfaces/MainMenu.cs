using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private SubMenu m_ListOfItems;

        public MainMenu(string i_MenuTitle)
        {
            m_ListOfItems = new SubMenu(i_MenuTitle);
        }

        public SubMenu ListOfItems
        {
            get
            {
                return m_ListOfItems;
            }
        }

        public void Show()
        {
            UserInteraction.Show(m_ListOfItems);
            //int userChoice = -1;

            //// need to change 0 to const
            //while (!userChoice.Equals(0))
            //{
            //    userChoice = UserInteraction.Display(m_ListOfItems);

            //    // need to change 0 to const
            //    if (!userChoice.Equals(0))
            //    {
            //        //need to change 1 to const
            //        m_ListOfItems.MenuNodes[userChoice - 1].DoWhenClicked();
            //    }
            //}
        }
    }
}
