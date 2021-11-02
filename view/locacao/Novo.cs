using System;
using System.Drawing;
using System.Windows.Forms;

namespace Loucaliza.view.locacao
{
    public class NovaLocacaoView : Form
    {
        public NovaLocacaoView()
        {
            this.Text = "Nova Locação";
            this.MinimumSize = new Size(800, 600);
            this.Execute();
        }

        public void Execute()
        {
            Button salvar = new Button();
            salvar.Text = "Salvar";
            salvar.Click += new EventHandler(SalvarClick);

            Controls.Add(salvar);
        }

        public void SalvarClick(object sender, EventArgs eventArgs)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}