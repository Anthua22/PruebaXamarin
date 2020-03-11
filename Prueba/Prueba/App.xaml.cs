using Prueba.Interfaces;
using Prueba.Utilidades;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba
{
    public partial class App : Application
    {
        //Si es false es modo claro y si es true modo oscuro
        private bool windowsmode = false;
        private void Mode()
        {
            string mode = DependencyService.Get<IFileHelper>().CheckMode();
            if (mode == "ON")
            {
                windowsmode = true;
            }
            else
            {
                windowsmode = false;
            }
        }
        public App()
        { 
            Mode();
            ChangesColors.CreateStruct(windowsmode);
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
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
