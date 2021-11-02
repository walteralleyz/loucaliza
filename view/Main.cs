using System;
using System.Drawing;
using System.Windows.Forms;
using Loucaliza;
using Loucaliza.view;
using Loucaliza.view.locacao;
using Loucaliza.view.veiculo;
using Loucaliza.view.cliente;
using Loucaliza.utils;

namespace Loucaliza.view
{
    public class MainView : Form
    {

        public void Execute()
        {
            TextBox textBox = new TextBox();
            ButtonUtils buttonUtils = new ButtonUtils();
            Button locacaoButton = buttonUtils.CreateMenuButton("Locações", new EventHandler(LocacaoButtonClick));
            Button clienteButton = buttonUtils.CreateMenuButton("Clientes", new EventHandler(ClienteButtonClick));
            Button veiculoButton = buttonUtils.CreateMenuButton("Veículos", new EventHandler(VeiculoButtonClick));

            textBox.Text = "Localiza";

            Controls.Add(textBox);
            Controls.Add(locacaoButton);
            Controls.Add(clienteButton);
            Controls.Add(veiculoButton);

            this.MinimumSize = new Size(800, 600);
            this.Text = "LoucaLiza - Locadora de Veículos";
            Application.Run(this);
        }

        public void LocacaoButtonClick(object sender, EventArgs eventArgs)
        {
            LocacaoView locacaoView = new LocacaoView(this);

            locacaoView.Execute();
            locacaoView.Show();

            this.Hide();
        }

        public void VeiculoButtonClick(object sender, EventArgs eventArgs)
        {
            VeiculoView veiculoView = new VeiculoView(this);

            veiculoView.Execute();
            veiculoView.Show();

            this.Hide();
        }

        public void ClienteButtonClick(object sender, EventArgs eventArgs)
        {
            ClienteView clienteView = new ClienteView(this);
            
            clienteView.Execute();
            clienteView.Show();

            this.Hide();
        }
    }
}