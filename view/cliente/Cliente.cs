using System;
using System.Drawing;
using System.Windows.Forms;
using Loucaliza;
using Loucaliza.utils;

namespace Loucaliza.view.cliente
{
    public class ClienteView : View
    {
        public ClienteView(MainViewEventControl eventControl) : base(eventControl, new NovoClienteView())
        {
            this.Text = "Clientes";
            this.MinimumSize = new Size(800, 600);
            this.Execute();
        }

        public void Execute()
        {
            ButtonUtils buttonUtils = new ButtonUtils();
            Button menu = buttonUtils.CreateMenuButton("Menu", new EventHandler(MenuClick));
            Button novo = buttonUtils.CreateMenuButton("Novo Cliente", new EventHandler(NovoClick));

            Controls.Add(menu);
            Controls.Add(novo);
        }
    }
}