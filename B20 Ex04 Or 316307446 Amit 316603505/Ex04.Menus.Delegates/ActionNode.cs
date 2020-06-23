using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public delegate void ActionToPerformHandler();

    public class ActionNode : MenuNode
    {
        public event ActionToPerformHandler ActionClicked;

        public ActionNode(string i_Title, ActionToPerformHandler i_ActionClicked)
        {
            Title = i_Title;
            ActionClicked += i_ActionClicked;
        }

        public override void OnClick()
        {
            Console.Clear();
            if(ActionClicked != null)
            {
                ActionClicked.Invoke();
            }

            UserInteraction.PressAnyKetToContinue();
        }
    }
}
