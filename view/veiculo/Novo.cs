using System;
using System.Drawing;
using System.Windows.Forms;

namespace Loucaliza.view.veiculo
{
    public class NovoVeiculoView : Form
    {
        public NovoVeiculoView()
        {
            this.Text = "Novo Veículo";
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