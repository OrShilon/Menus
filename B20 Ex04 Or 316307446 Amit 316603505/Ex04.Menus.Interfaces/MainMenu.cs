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
            m_ListOfItems.MenuNodes = new List<MenuNode>();
        }

        public string ExitMessage
        {
            get
            {
                return m_ExitMessage;
            }
        }
    }
}
