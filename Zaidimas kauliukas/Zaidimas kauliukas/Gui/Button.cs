using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Gui
{
    class Button : GuiObject
    {

        private Frame notActiveFrame;
        private Frame activeFrame;

        private bool isActive = false;
        private TextLine textLine;

        public Button(int x, int y, int width, int height, string buttonText) : base(x, y, width, height)
        {
            notActiveFrame = new Frame(x, y, width, height, '+');
            activeFrame = new Frame(x + 7, y + 1, width - 14, height - 2, '*');

            textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);
        }

        public override void Render()
        {
            if (isActive)
            {
                notActiveFrame.Render();
                activeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }

            textLine.Render();
        }

        public void SetActive()
        {
            isActive = true;
        }

        public void SetInActive()
        {
            isActive = false;
        }
    }
}
