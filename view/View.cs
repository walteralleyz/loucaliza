using System;
using System.Drawing;
using System.Windows.Forms;
using Loucaliza;
using Loucaliza.utils;

namespace Loucaliza.view
{
    public class View : Form
    {

        private MainViewEventControl eventControl;
        private Form novoForm;

        public View(MainViewEventControl eventControl, Form novoForm)
        {
            this.eventControl = eventControl;
            this.novoForm = novoForm;
            this.FormClosing += new FormClosingEventHandler(eventControl.CloseMainView);
        }

        public void MenuClick(object sender, EventArgs eventArgs)
        {
            this.Dispose();
            this.eventControl.ShowMainView();
        }

        public void NovoClick(object sender, EventArgs eventArgs)
        {
            if(novoForm.ShowDialog(this) == DialogResult.Yes)
            {
                novoForm.Close();
            }
        }
    }
}