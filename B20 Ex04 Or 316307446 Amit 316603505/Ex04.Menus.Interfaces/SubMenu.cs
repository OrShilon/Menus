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
        private SubMenu m_ParentMenu = null;
        private List<MenuNode> m_MenuNodes = new List<MenuNode>();


        public List<MenuNode> MenuNodes
        {
            get
            {
                return m_MenuNodes;
            }
        }

        public SubMenu(string i_MenuTitle)
        {
            Title = i_MenuTitle;
            m_MenuNodes = new List<MenuNode>();
        }


        // Node can be subMenu or ItemMenu
        public void AddMenuNode(MenuNode i_NodeToAdd)
        {
            m_MenuNodes.Add(i_NodeToAdd);
            i_NodeToAdd.ParentMenu = this;
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
        }
    }
}
