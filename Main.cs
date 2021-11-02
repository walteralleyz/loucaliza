using System;
using Loucaliza.view;
using Loucaliza.utils;

namespace Loucaliza
{
    public class MainApp
    {
        public static void Main(string[] args)
        {
            Database.InitDB();
            MainView mainView = new MainView();
            mainView.Execute();
        }
    }
}

