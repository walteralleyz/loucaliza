using System;
using System.Drawing;
using System.Windows.Forms;
using Loucaliza;
using Loucaliza.utils;

namespace Loucaliza.view.veiculo
{
    public class VeiculoView : Form
    {
        private MainView mainView;

        public VeiculoView(MainView mainView)
        {
            this.Text = "Veículos";
            this.MinimumSize = new Size(800, 600);
            this.mainView = mainView;
        }

        public void Execute()
        {
            ButtonUtils buttonUtils = new ButtonUtils();
            Button menu = buttonUtils.CreateMenuButton("Menu", new EventHandler(MenuClick));
            Button novo = buttonUtils.CreateMenuButton("Novo Veículo", new EventHandler(NovoClick));

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
            NovoVeiculoView novoVeiculoView = new NovoVeiculoView(this);

            novoVeiculoView.Execute();
            novoVeiculoView.Show();

            this.Hide();
        }
    }
}