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

        private MainViewEventControl eventControl;

        public void Execute()
        {
            ButtonUtils buttonUtils = new ButtonUtils();
            Button locacaoButton = buttonUtils.CreateMenuButton("Locações", new EventHandler(LocacaoButtonClick));
            Button clienteButton = buttonUtils.CreateMenuButton("Clientes", new EventHandler(ClienteButtonClick));
            Button veiculoButton = buttonUtils.CreateMenuButton("Veículos", new EventHandler(VeiculoButtonClick));

            eventControl = new MainViewEventControl(this);

            Controls.Add(new TitlePanel().BuildPanel());
            Controls.Add(locacaoButton);
            Controls.Add(clienteButton);
            Controls.Add(veiculoButton);

            this.MinimumSize = new Size(800, 600);
            this.Text = "LoucaLiza - Locadora de Veículos";
            Application.Run(this);
        }

        public void LocacaoButtonClick(object sender, EventArgs eventArgs)
        {
            OpenViewRoutine(new LocacaoView(this.eventControl));
        }

        public void VeiculoButtonClick(object sender, EventArgs eventArgs)
        {
            OpenViewRoutine(new VeiculoView(this.eventControl));
        }

        public void ClienteButtonClick(object sender, EventArgs eventArgs)
        {
            OpenViewRoutine(new ClienteView(this.eventControl));
        }

        public void OpenViewRoutine(View view)
        {
            view.Show();

            this.Hide();
        }
    }
}