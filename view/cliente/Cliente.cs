using System;
using System.Drawing;
using System.Windows.Forms;
using Loucaliza.utils;

namespace Loucaliza.view.cliente
{
    public class ClienteView : Form
    {
        private MainView mainView;

        public ClienteView(MainView mainView)
        {
            this.Text = "Clientes";
            this.MinimumSize = new Size(800, 600);
            this.mainView = mainView;
        }

        public void execute()
        {
            ButtonUtils buttonUtils = new ButtonUtils();
            Button menu = buttonUtils.CreateMenuButton("Menu", new EventHandler(MenuClick));
            Button novo = buttonUtils.CreateMenuButton("Novo Cliente", new EventHandler(NovoClick));

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
            NovoClienteView novoClienteView = new NovoClienteView(this);

            novoClienteView.execute();
            novoClienteView.Show();

            this.Hide();
        }
    }
}