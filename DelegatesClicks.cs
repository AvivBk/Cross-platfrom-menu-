using System;
using System.Linq;

namespace Ex04.Menus.Delegates
{
    public class DelegatesClicks
    {
        protected static void showVersion_Click(MenuItem i_Invoker)
        {
            Console.WriteLine("Version: {0}", Environment.Version.ToString());
            EndClick();
        }

        protected static void countSpaces_Click(MenuItem i_Invoker)
        {
            Console.WriteLine("Enter a sentence: ");
            Console.WriteLine("Provide the Text to analyze");
            string input = Console.ReadLine();
            int countSpaces = input.Count(Char.IsWhiteSpace);
            Console.WriteLine("There are {0} spaces in your sentence.", countSpaces);
            EndClick();
        }

        protected static void showTime_Click(MenuItem i_Invoker)
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine("Local time is  {0}", localDate.ToShortTimeString());
            EndClick();
        }

        protected static void showDate_Click(MenuItem i_Invoker)
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine("current local Date :");
            Console.WriteLine(localDate.ToShortDateString());
            EndClick();
        }

        private static void EndClick()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
