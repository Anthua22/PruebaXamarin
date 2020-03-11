using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using System.IO;
using Prueba.Interfaces;

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
                Navigation.PushAsync(new PageLogin());
                
           }
           catch(Exception e)
           {
                DisplayAlert("Error", "Error: " + e.Message, "Ok");
           }
            
           
        }

    }
}
