using ConsoleGame.Gui;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas_kauliukas.Gui
{
    class MainMenu : Window
    {
        private Button startButton;
        private Button quitButton;
        private TextBlock titleTextBlock;
        private List<Button> menuButtons = new List<Button>();

        public MainMenu() : base(0, 0, 120, 30, '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Zaidimas 'Kauliukas'", "Andrius Zakarauskas coding!", "Made at home!" });

            startButton = new Button(30, 13, 18, 5, "P to play");

            quitButton = new Button(70, 13, 18, 5, "Q to quit");

            menuButtons.Add(startButton);
            menuButtons.Add(quitButton);
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

            startButton.Render();
            quitButton.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}
