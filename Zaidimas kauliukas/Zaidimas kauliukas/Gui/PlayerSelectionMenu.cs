using ConsoleGame.Gui;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas_kauliukas.Gui
{
    class PlayerSelectionMenu : Window
    {
        private Button P2;
        private Button P3;
        private Button P4;
        private Button P5;
        private Button P6;
        private Button P7;

        private TextBlock titleTextBlock;
        private List<Button> menuButtons = new List<Button>();

        public PlayerSelectionMenu() : base(0, 0, 120, 30, '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Pasirinkite zaideju skaiciu"});

            menuButtons.Add (P2 = new Button(30, 10, 18, 5, "P2"));
            P2.SetActive();

            menuButtons.Add (P3 = new Button(47, 10, 18, 5, "P3"));

            menuButtons.Add (P4 = new Button(64, 10, 18, 5, "P4"));

            menuButtons.Add (P5 = new Button(30, 14, 18, 5, "P5"));

            menuButtons.Add (P6 = new Button(47, 14, 18, 5, "P6"));

            menuButtons.Add (P7 = new Button(64, 14, 18, 5, "P7"));
        } 

        public List<Button> MenuButtons
        {
            get { return menuButtons; }
            set { menuButtons = value; }
        }

        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            foreach (var button in menuButtons)
            {
                button.Render();
            }

            Console.SetCursorPosition(0, 0);
        }
    }
}
