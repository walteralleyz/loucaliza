using System;
using System.Drawing;
using System.Windows.Forms;
using Loucaliza.utils;

namespace Loucaliza.view.locacao
{
    public class LocacaoView : Form
    {
        private MainView mainView;

        public LocacaoView(MainView mainView)
        {
            this.MinimumSize = new Size(800, 600);
            this.Text = "Loucaliza - Locações";
            this.mainView = mainView;
        }

        public void execute()
        {
            ButtonUtils buttonUtils = new ButtonUtils();
            Button menu = buttonUtils.CreateMenuButton("Menu", new EventHandler(MenuClick));
            Button novo = buttonUtils.CreateMenuButton("Nova Locação", new EventHandler(NovoClick));

            Controls.Add(menu);
            Controls.Add(novo);
        }

        public void MenuClick(object sender, EventArgs eventArgs)
        {
            this.Hide();
            this.mainView.Show();
        }

        public void NovoClick(object sender, EventArgs eventArgs)
        {
            NovaLocacaoView novaLocacaoView = new NovaLocacaoView(this);

            novaLocacaoView.execute();
            novaLocacaoView.Show();

            this.Hide();
        }
    }
}