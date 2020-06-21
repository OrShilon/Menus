using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class Menu
    {
        private List<MenuNode> m_MenuNodes;
        private Menu m_ParentMenu = null;
        private string m_MenuTitle;

        public List<MenuNode> MenuNodes
        {
            get
            {
                return m_MenuNodes;
            }

            set
            {
                m_MenuNodes = value;
            }
        }

        public string MenuTitle
        {
            get
            {
                return m_MenuTitle;
            }

            set
            {
                m_MenuTitle = value;
            }
        }

        // Node can be subMenu or ItemMenu
        public void AddMenuNode(MenuNode i_NodeToAdd)
        {
            m_MenuNodes.Add(i_NodeToAdd);
        }

        // Node can be subMenu or ItemMenu
        public void RemoveMenuNode(MenuNode i_NodeToAdd)
        {
            if(m_MenuNodes != null) 
            {
                if(m_MenuNodes.Contains(i_NodeToAdd))
                {
                    m_MenuNodes.Add(i_NodeToAdd);
                }
            }
        }
    }
}
