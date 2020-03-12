using Prueba.Interfaces;
using Prueba.Servicio;
using Prueba.Utilidades;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace Prueba
{
    public partial class App : Application
    {
        //Si es false es modo claro y si es true modo oscuro
        private bool windowsmode = false;
        //private SQLiteAsyncConnection _conn; 
     
        public App()
        { 
            Mode();
            ChangesColors.CreateStruct(windowsmode);
            InitializeComponent();
           // _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            MainPage = new NavigationPage(new MainPage());
        }
        
      /*  private void Check()
        {
            if (!DependencyService.Get<IFileHelper>().Exists())
            {
                _conn.InsertAsync(true);
            }
        }*/

        private void Mode()
        {
            try
            {
                if (DependencyService.Get<IFileHelper>().Exists())
                {
                    string mode = DependencyService.Get<IFileHelper>().CheckMode();
                    if (mode == "ON")
                    {
                        windowsmode = true;
                    }
                    else
                    {
                        windowsmode = false;
                        //_conn.InsertAsync(windowsmode);
                    }
                }
                else
                {
                    DependencyService.Get<IFileHelper>().getDataStoragePath();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
