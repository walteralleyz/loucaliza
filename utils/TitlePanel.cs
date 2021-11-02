using System;
using System.Drawing;
using System.Windows.Forms;

namespace Loucaliza.utils
{
    public class TitlePanel : FlowLayoutPanel
    {
        public TitlePanel BuildPanel()
        {
            BackColor = Color.FromArgb(63, 176, 137);
            Size = new Size(800, 50);
            WrapContents = false;

            Image carImage = Image.FromFile("./assets/car.png");
            Bitmap carBitmap = new Bitmap(carImage, 40, 40);

            PictureBox box = new PictureBox();
            box.ClientSize = new Size(50, 50);
            box.Image = carBitmap as Image;
            box.SizeMode = PictureBoxSizeMode.CenterImage;
            box.Padding = new Padding(5);

            Label title = new Label();
            title.Text = "LoucaLiza - Locadora de Veículos";
            title.ForeColor = Color.White;
            title.Size = new Size(740, 30);
            title.Font = new Font(title.Font.Name, 18, FontStyle.Italic | FontStyle.Bold);
            title.Padding = new Padding(5);

            Controls.Add(title);
            Controls.Add(box);

            return this;
        }
    }
}