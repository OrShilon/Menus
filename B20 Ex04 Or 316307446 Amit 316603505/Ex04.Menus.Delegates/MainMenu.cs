using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
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
        }
    }
}
