using System;
using System.Drawing;
using System.Windows.Forms;

namespace Loucaliza.view.locacao
{
    public class NovaLocacaoView : Form
    {
        private LocacaoView locacaoView;

        public NovaLocacaoView(LocacaoView locacaoView)
        {
            this.Text = "Nova Locação";
            this.MinimumSize = new Size(800, 600);
            this.locacaoView = locacaoView;
        }

        public void execute()
        {
            Button salvar = new Button();
            salvar.Text = "Salvar";
            salvar.Click += new EventHandler(SalvarClick);

            Controls.Add(salvar);
        }

        public void SalvarClick(object sender, EventArgs eventArgs)
        {
            this.Hide();
            this.locacaoView.Show();
        }
    }
}