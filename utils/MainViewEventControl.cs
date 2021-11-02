using System;
using System.Windows.Forms;
using Loucaliza;
using Loucaliza.utils;
using Loucaliza.view;

namespace Loucaliza.utils
{
    public class MainViewEventControl
    {

        private MainView mainView;

        public MainViewEventControl(MainView mainView)
        {
            this.mainView = mainView;
        }

        public void CloseMainView(object sender, FormClosingEventArgs eventArgs)
        {
            var result = MessageBox.Show("Desejar mesmo encerrar a aplicação?",
                "Encerrando aplicação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                mainView.Close();
                return;
            }

            eventArgs.Cancel = true;
        }

        public void ShowMainView()
        {
            mainView.Show();
        }
    }
}