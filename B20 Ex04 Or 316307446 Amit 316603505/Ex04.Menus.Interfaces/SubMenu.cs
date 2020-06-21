using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuNode
    {

        private const string m_ExitMessage = "Exit";
        private const string m_BackMessage = "Back";
        private List<MenuNode> m_MenuNodes;

        public SubMenu(string i_MenuTitle)
        {
            Title = i_MenuTitle;
            m_MenuNodes = new List<MenuNode>();
        }


        // Node can be subMenu or ItemMenu
        public void AddMenuNode(MenuNode i_NodeToAdd)
        {
            m_MenuNodes.Add(i_NodeToAdd);
        }

        // Node can be subMenu or ItemMenu
        public void RemoveMenuNode(MenuNode i_NodeToAdd)
        {
            if (m_MenuNodes != null)
            {
                if (m_MenuNodes.Contains(i_NodeToAdd))
                {
                    m_MenuNodes.Add(i_NodeToAdd);
                }
            }
        }

        public override void DoWhenClicked()
        {
            int index = 1;

            Console.WriteLine(Title + Environment.NewLine);
            foreach(MenuNode item in m_MenuNodes)
            {
                Console.WriteLine("{0}. {1}", index, item);
                index++;
            }

            Console.WriteLine("0. {0}", ParentMenu == null ? m_ExitMessage : m_BackMessage);
            Console.WriteLine("Please Choose the coresponding number to the button you want to choose");
        }
    }
}
