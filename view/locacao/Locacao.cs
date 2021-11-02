using System;
using System.Drawing;
using System.Windows.Forms;
using Loucaliza;
using Loucaliza.utils;
using Loucaliza.view;

namespace Loucaliza.view.locacao
{
    public class LocacaoView : View
    {
        public LocacaoView(MainViewEventControl eventControl) : base(eventControl, new NovaLocacaoView())
        {
            this.MinimumSize = new Size(800, 600);
            this.Text = "Loucaliza - Locações";
            this.Execute();
        }

        public void Execute()
        {
            ButtonUtils buttonUtils = new ButtonUtils();
            Button menu = buttonUtils.CreateMenuButton("Menu", new EventHandler(MenuClick));
            Button novo = buttonUtils.CreateMenuButton("Nova Locação", new EventHandler(NovoClick));

            Controls.Add(menu);
            Controls.Add(novo);
        }
    }
}