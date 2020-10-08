using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.LocalDB.Model;
using XF.LocalDB.AlunoViewModels;
using XF.LocalDB;
using XF.LocalDB.View;

namespace XF.LocalDB
{
    public partial class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new View.Aluno.MainPage());
        }
        static Aluno alunoModel;
        public static Aluno AlunoModel
        {
            get
            {
                if (alunoModel == null)
                {
                    alunoModel = new Aluno();
                }
                return alunoModel;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
