using System;
using System.Drawing;
using System.Windows.Forms;

namespace Loucaliza.utils
{
    public class ButtonUtils
    {
        private int x = 300;
        private int y = 100;

        public Button CreateMenuButton(string text, EventHandler eventHandler)
        {
            Button button = new Button();
            button.Text = text;
            button.Height = 100;
            button.Width = 200;
            button.Click += eventHandler;
            button.Location = new Point(x, y);

            y += 125;

            return button;
        }
    }
}