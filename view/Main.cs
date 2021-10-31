using System;
using System.Drawing;
using System.Windows.Forms;
using Loucaliza.view.locacao;
using Loucaliza.view.veiculo;
using Loucaliza.view.cliente;
using Loucaliza.utils;

namespace Loucaliza.view
{
    public class MainView : Form
    {

        public void execute()
        {
            ButtonUtils buttonUtils = new ButtonUtils();
            Button locacaoButton = buttonUtils.CreateMenuButton("Locações", new EventHandler(LocacaoButtonClick));
            Button clienteButton = buttonUtils.CreateMenuButton("Clientes", new EventHandler(ClienteButtonClick));
            Button veiculoButton = buttonUtils.CreateMenuButton("Veículos", new EventHandler(VeiculoButtonClick));

            Controls.Add(locacaoButton);
            Controls.Add(clienteButton);
            Controls.Add(veiculoButton);

            this.MinimumSize = new Size(800, 600);
            this.Text = "LoucaLiza";
            Application.Run(this);
        }

        public void LocacaoButtonClick(object sender, EventArgs eventArgs)
        {
            LocacaoView locacaoView = new LocacaoView(this);

            locacaoView.execute();
            locacaoView.Show();

            this.Hide();
        }

        public void VeiculoButtonClick(object sender, EventArgs eventArgs)
        {
            VeiculoView veiculoView = new VeiculoView(this);

            veiculoView.execute();
            veiculoView.Show();

            this.Hide();
        }

        public void ClienteButtonClick(object sender, EventArgs eventArgs)
        {
            ClienteView clienteView = new ClienteView(this);
            
            clienteView.execute();
            clienteView.Show();

            this.Hide();
        }
    }
}