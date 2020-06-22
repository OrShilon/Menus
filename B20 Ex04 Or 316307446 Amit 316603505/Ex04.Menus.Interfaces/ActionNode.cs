using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ActionNode : MenuNode
    {
        private IExecuteAction m_ActionToPerform;

        public ActionNode(string i_Title, IExecuteAction i_ActionToPerform)
        {
            Title = i_Title;
            m_ActionToPerform = i_ActionToPerform;
        }

        public override void DoWhenClicked()
        {
            Console.Clear();
            m_ActionToPerform.Execute();
            UserInteraction.PressAnyKetToContinue();
        }
    }
}
