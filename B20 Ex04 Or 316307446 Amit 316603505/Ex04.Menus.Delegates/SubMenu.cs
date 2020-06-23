using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuNode
    {
        private readonly List<MenuNode> r_MenuNodes;

        public SubMenu(string i_MenuTitle)
        {
            Title = i_MenuTitle;
            r_MenuNodes = new List<MenuNode>();
        }

        public List<MenuNode> MenuNodes
        {
            get
            {
                return r_MenuNodes;
            }
        }

        // Node can be subMenu or ItemMenu
        public void AddMenuNode(MenuNode i_NodeToAdd)
        {
            r_MenuNodes.Add(i_NodeToAdd);
            i_NodeToAdd.ParentMenu = this;
        }

        // Node can be subMenu or ItemMenu
        public void RemoveMenuNode(MenuNode i_NodeToAdd)
        {
            if (r_MenuNodes != null)
            {
                if (r_MenuNodes.Contains(i_NodeToAdd))
                {
                    r_MenuNodes.Add(i_NodeToAdd);
                }
            }
        }

        public override void OnClick()
        {
            UserInteraction.Show(this);
        }
    }
}
