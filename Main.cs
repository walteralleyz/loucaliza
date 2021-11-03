using Loucaliza.view;
using Loucaliza.utils;

namespace Loucaliza
{
    public class MainApp
    {
        public static void Main(string[] args)
        {
            MainView mainView = new MainView();

            Database.InitDB();
            mainView.Execute();
        }
    }
}
