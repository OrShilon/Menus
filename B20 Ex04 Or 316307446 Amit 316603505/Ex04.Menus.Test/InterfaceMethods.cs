using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class InterfaceMethods
    {
         public class CountCapitals : IExecuteAction
        {
            public void Execute()
            {
                string userSentence;
                int numOfCapitals = 0;

                Console.WriteLine("Please enter a sentence to know how many capitals letters are in it");
                userSentence = Console.ReadLine();
                for (int i = 0; i < userSentence.Length; i++)
                {
                    //need to change 'A' and 'Z' to const
                    if(userSentence[i] >= 'A' && userSentence[i] <= 'Z')
                    {
                        numOfCapitals++;
                    }
                }

                Console.WriteLine("You have {0} Capital letters in your sentence.", numOfCapitals);
            }
        }

        public class ShowVersion : IExecuteAction
        {
            public void Execute()
            {
                Console.WriteLine("Version: 20.2.4.30620");
            }
        }

        public class ShowTime : IExecuteAction
        {
            public void Execute()
            {
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            }
        }

        public class ShowDate : IExecuteAction
        {
            public void Execute()
            {
                Console.WriteLine(DateTime.Today.ToString("dd-MM-yyyy"));
            }
        }
    }
}
