
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegatesTest :DelegatesClicks
    {
        public static void RunTest()
        {
            Menu delegatesMainMenu = new Menu(" Delegates Menu ");
          
            MenuItem subMenu1 = new Menu("Version and Spaces");
            subMenu1.AddItem(new MenuItem("Show Version"), showVersion_Click);
            subMenu1.AddItem(new MenuItem("Count Spaces"), countSpaces_Click);

            MenuItem subMenu2 = new Menu(" Date and Time");
            subMenu2.AddItem(new MenuItem("Show Time"), showTime_Click);
            subMenu2.AddItem(new MenuItem("Show Date"), showDate_Click);

            delegatesMainMenu.AddItem(subMenu1, subMenu1.OperateMenu);
            delegatesMainMenu.AddItem(subMenu2, subMenu2.OperateMenu);

            delegatesMainMenu.OperateMenu(default);
        }
    }
    
}
