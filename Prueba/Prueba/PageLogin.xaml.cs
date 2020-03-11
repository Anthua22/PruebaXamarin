using Prueba.Interfaces;
using Prueba.Utilidades;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLogin : ContentPage
    {
        public string User { get; set; }
        public string Pass { get; set; }

        public PageLogin()
        {

            InitializeComponent();
            User = "pepe@akrolis.com";
            Pass = "Pepe@123";
            LoginButton.Clicked += LoginButton_Clicked;
            ShowPassword.CheckedChanged += MostrarPassword_CheckedChanged;
            
           // AddCheck();
        }
        private void MostrarPassword_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (ShowPassword.IsChecked)
            {
                PassEntry.IsPassword = false;
            }
            else
            {
                PassEntry.IsPassword = true;
            }
        }

        private string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }



        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones.ValidarEmail(UserEntry.Text))
                {

                    if (Validaciones.ValidarPass(PassEntry.Text))
                    {  
                                            
                        if (UserEntry.Text == User && PassEntry.Text == Pass)
                        {

                            Navigation.PushAsync(new PageDashboard());
                            
                        }
                        else
                        {
                            DisplayAlert("Error", "Usuario o contraseña incorrecto", "Ok");
                        }

                    }
                    else
                    {
                        DisplayAlert("Error", "Formato de contraseña Incorrecto", "Ok");
                    }

                }
                else
                {
                    DisplayAlert("Error", "Formato de usuario Incorrecto", "Ok");
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Error: " + ex.Message, "Ok");
            }
           
        }
    }
}