using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private SubMenu m_ListOfMenuNodes;

        public MainMenu(string i_MenuTitle)
        {
            m_ListOfMenuNodes = new SubMenu(i_MenuTitle);
        }

        public SubMenu ListOfMenuNodes
        {
            get
            {
                return m_ListOfMenuNodes;
            }
        }

        public void Show()
        {
            UserInteraction.Show(m_ListOfMenuNodes);
        }
    }
}
