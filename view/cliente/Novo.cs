using System;
using System.Drawing;
using System.Windows.Forms;

namespace Loucaliza.view.cliente
{
    public class NovoClienteView : Form
    {
        private ClienteView clienteView;
        public NovoClienteView(ClienteView clienteView)
        {
            this.Text = "Novo Cliente";
            this.MinimumSize = new Size(800, 600);
            this.clienteView = clienteView;
        }

        public void Execute()
        {
            Button salvar = new Button();
            salvar.Text = "Salvar";
            salvar.Click += new EventHandler(ClienteClick);

            Controls.Add(salvar);
        }

        public void ClienteClick(object sender, EventArgs eventArgs)
        {
            this.Hide();
            this.clienteView.Show();
        }
    }
}