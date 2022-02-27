
using Ex04.Menus.Interfaces;
using Ex04.Menus.Interfaces.Functions;

namespace Ex04.Menus.Test
{
    public class InterfacesTest
    {
        public static void RunTest()
        {
            Menu mainMenu = new Menu("Interfaces main menu");
            
            MenuItem versionsAndSpaceItem = new Menu("Version and Spaces");
            versionsAndSpaceItem.AddItem(new MenuItem("Show Version"), new ShowVersion());
            versionsAndSpaceItem.AddItem(new MenuItem("Count Spaces"), new CountSpaces());
          

            MenuItem DateAndTimeItem = new Menu("Show Date or Time");
            DateAndTimeItem.AddItem(new MenuItem("Show Time"), new ShowTime());
            DateAndTimeItem.AddItem(new MenuItem("Show Date"), new ShowDate());
          
            mainMenu.AddItem(versionsAndSpaceItem, versionsAndSpaceItem as IClickObserver);
            mainMenu.AddItem(DateAndTimeItem, DateAndTimeItem as IClickObserver);

            mainMenu.OperateMenu();


        }

    }
}
