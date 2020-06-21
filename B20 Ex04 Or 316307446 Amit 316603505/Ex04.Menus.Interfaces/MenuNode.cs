using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuNode 
    {
        private string m_Title;
        private Menu m_ParentMenu = null;

        public abstract void DoWhenClicked();


        public string Title
        {
            get
            {
                return m_Title;
            }

            set
            {
                m_Title = value;
            }
        }

        public Menu ParentMenu
        {
            get
            {
                return m_ParentMenu;
            }

            set
            {
                m_ParentMenu = value;
            }
        }
    }
}
