using System;
using System.Drawing;
using System.Windows.Forms;
using Loucaliza;
using Loucaliza.utils;

namespace Loucaliza.view.veiculo
{
    public class VeiculoView : View
    {
        public VeiculoView(MainViewEventControl eventControl) : base(eventControl, new NovoVeiculoView())
        {
            this.Text = "Veículos";
            this.MinimumSize = new Size(800, 600);
            this.Execute();
        }

        public void Execute()
        {
            ButtonUtils buttonUtils = new ButtonUtils();
            Button menu = buttonUtils.CreateMenuButton("Menu", new EventHandler(MenuClick));
            Button novo = buttonUtils.CreateMenuButton("Novo Veículo", new EventHandler(NovoClick));

            Controls.Add(menu);
            Controls.Add(novo);
        }
    }
}