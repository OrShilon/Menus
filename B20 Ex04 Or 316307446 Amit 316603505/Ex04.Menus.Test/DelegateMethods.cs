using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    class DelegateMethods
    {
        private const char k_FirstCapitalLetter = 'A';
        private const char k_LastCapitalLetter = 'Z';

        public static void CountCapitals()
        {

            string userSentence;
            int numOfCapitals = 0;

            Console.WriteLine("Please enter a sentence to know how many capitals letters are in it");
            userSentence = Console.ReadLine();
            for (int i = 0; i < userSentence.Length; i++)
            {
                if (userSentence[i] >= k_FirstCapitalLetter && userSentence[i] <= k_LastCapitalLetter)
                {
                    numOfCapitals++;
                }
            }

            Console.WriteLine("You have {0} Capital letters in your sentence.", numOfCapitals);
        }

        public static void ShowVersion()
        {
            Console.WriteLine("Version: 20.2.4.30620");
        }

        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }

        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Today.ToString("dd-MM-yyyy"));
        }
    }
}
