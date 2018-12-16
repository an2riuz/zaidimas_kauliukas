using System;
using Zaidimas_kauliukas.View;

namespace Zaidimas_kauliukas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            MenuController menuController = new MenuController();
            menuController.ShowMainMenu();

            Console.ReadKey();
        }
    }
}
