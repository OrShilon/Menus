using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Methods
    {
         public class CountCapitals : IExecuteAction
        {
            private const char k_FirstCapitalLetter = 'A';
            private const char k_LastCapitalLetter = 'Z';
          
            public void Execute()
            {
                string userSentence;
                int numOfCapitals = 0;

                Console.WriteLine("Please enter a sentence to know how many capitals letters are in it");
                userSentence = Console.ReadLine();
                for (int i = 0; i < userSentence.Length; i++)
                {
                    if(userSentence[i] >= k_FirstCapitalLetter && userSentence[i] <= k_LastCapitalLetter)
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
