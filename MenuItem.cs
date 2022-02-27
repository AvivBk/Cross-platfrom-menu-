using System;


namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private readonly string m_Title;
        public event Action<MenuItem> Click;

        public MenuItem(string i_Title)
        {
            m_Title = i_Title;
        }

        public void HandleClick()
        {
            OnClick();
        }

        public virtual void OperateMenu(MenuItem i_Invoker)
        {
        }

        public virtual void AddItem(MenuItem i_MenuItem, Action<MenuItem> i_Action)
        {
        }

        protected void OnClick()
        {
            Click?.Invoke(this);
        }

        public void Show()
        {
            Console.WriteLine(m_Title);
        }
    }
}
