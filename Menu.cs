using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class Menu : MenuItem
    {
        private readonly List<MenuItem> m_Items = new List<MenuItem>();
        private readonly string m_Title;
        private static int m_MenuLevel = 1;
        public Menu(string i_Title) : base(i_Title)
        {
            m_Title = i_Title;

            if (m_MenuLevel > 0) // its a static var
            {
               AddItem(new MenuItem("Back"), BackButton_Click);
            }
            else
            {
                AddItem(new MenuItem("Exit"), BackButton_Click);
            }
        }
        private void showMenu()
        {
            int idx = 0;
            Console.WriteLine(" {0}     (Level: {1})", m_Title, m_MenuLevel);
            Console.WriteLine("+======================================+");

            foreach (MenuItem item in m_Items)
            {
                Console.Write(idx++ + "). ");
                item.Show();
            }
            Console.WriteLine("+======================================+");
        }
        public  override void AddItem(MenuItem i_MenuItem, Action<MenuItem> i_Action)
        {
            m_Items.Add(i_MenuItem);
            m_Items[m_Items.Count -1].Click += i_Action;
        }
        public override void OperateMenu(MenuItem i_Invoker)
        {
            showMenu();
            bool v_isQuit = false;

            while (!v_isQuit)
            {

                string choice = getValidUserMenuChoice();
                int menuIndex = int.Parse(choice);

                if (m_Items.Count > menuIndex)
                {
                    m_MenuLevel++;
                    m_Items[menuIndex].HandleClick();
                    m_MenuLevel--;
                }
                else
                {
                    Console.WriteLine(" Invalid input ");
                }

                if (choice.Equals("0"))
                {
                    v_isQuit = true;
                }
                else
                {
                    showMenu();
                }
            }
        }

        private string getValidUserMenuChoice()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter your choice: ");
            string choice = Console.ReadLine();

            while (!isChoiceValid(choice))
            {
                choice = Console.ReadLine();
                Console.Clear();
                showMenu();
            }
            Console.Clear();
            return choice;
        }

        private bool isChoiceValid(string i_Choice)
        {
            bool v_isChoiceValid = false;

            try
            {
                char converted = char.Parse(i_Choice);
                if (char.IsDigit(converted))
                {
                    v_isChoiceValid = true;
                }
                else
                {
                    Console.WriteLine("invalid choice. Please try again:");
                }
            }
            catch
            {
                Console.WriteLine("invalid choice. Please try again:");
            }
            return v_isChoiceValid;
        }
        public void BackButton_Click(MenuItem i_Invoker)
        {
            Console.Clear();
        }

    }
}
