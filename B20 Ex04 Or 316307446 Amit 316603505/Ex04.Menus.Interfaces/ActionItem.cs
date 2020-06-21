using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuNode
    {
        private IExecuteAction m_ActionToPerform;

        public ActionItem(IExecuteAction i_ActionToPerform)
        {
            m_ActionToPerform = i_ActionToPerform;
        }

        public override void DoWhenmClicked()
        {
            Console.Clear();
            m_ActionToPerform.Execute();
        }
    }
}
