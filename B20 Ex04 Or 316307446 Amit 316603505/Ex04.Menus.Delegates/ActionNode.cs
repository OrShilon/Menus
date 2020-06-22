using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{

    public delegate void ActionToDo();

    public class ActionNode : MenuNode
    {
        public event ActionToDo delegateAction;

        public ActionNode(string i_Title, ActionToDo i_delegateAction)
        {
            Title = i_Title;
            delegateAction += i_delegateAction;
        }

        public override void DoWhenClicked()
        {
            Console.Clear();
            if(delegateAction != null)
            {
                delegateAction.Invoke();
            }

            UserInteraction.PressAnyKetToContinue();
        }
    }
}
