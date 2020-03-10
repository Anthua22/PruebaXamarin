using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using System.IO;

namespace Prueba
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
    
        public MainPage()
        {
            InitializeComponent();
            CheckFile();

        }

        private void CheckFile()
        {
            try
            {
                if (File.Exists(@"C:/Proyectos/Prueba/Prueba/datos/credentials.txt"))
                {
                    Navigation.PushAsync(new PageDashboard());
                }
                else
                {

                    Navigation.PushAsync(new PageLogin());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
           
        }

    }
}
