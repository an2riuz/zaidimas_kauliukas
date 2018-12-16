using Zaidimas_kauliukas.View;
using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas_kauliukas.Gui;

namespace Zaidimas_kauliukas.View
{
    class MenuController
    {
        MainMenu mainMenu = new MainMenu();
        PlayerSelectionMenu playerSelectionMenu = new PlayerSelectionMenu();

        public MenuController()
        {

        }

        public void ShowMainMenu()
        {
            mainMenu.Render();

            bool needToRender = true;

            do
            {
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                int hashCode = pressedChar.Key.GetHashCode();

                switch (hashCode)
                {
                    case 80: // ConsoleKey.P
                        PlayerSelectionMenu();
                        break;

                    case 81: //ConsoleKey.Q
                        Environment.Exit(0);
                        break;
                }
                mainMenu.Render();
            } while (needToRender);
        }

        public void PlayerSelectionMenu()
        {
            playerSelectionMenu.Render();

            bool needToRender = true;
            int i = 0;

            do
            {
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                int hashCode = pressedChar.Key.GetHashCode();

                switch (hashCode)
                {
                    case 39: // ConsoleKey.RightArrow:
                        if (i < 2 && i >= 0)
                        {
                            i++;
                            playerSelectionMenu.MenuButtons[i].SetActive();
                            playerSelectionMenu.MenuButtons[i - 1].SetInActive();
                        }
                        break;

                    case 37: // ConsoleKey.LeftArrow:
                        if (i < 3 && i > 0)
                        {
                            playerSelectionMenu.MenuButtons[i - 1].SetActive();
                            playerSelectionMenu.MenuButtons[i].SetInActive();
                            i--;
                        }
                        break;

                    case 13: //ConsoleKey.Enter
                        //DiceSelectionMenu();
                        break;
                }
                playerSelectionMenu.Render();
            } while (needToRender);
        }
    }
}
