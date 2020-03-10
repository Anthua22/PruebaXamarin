using Prueba.Entidades;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSettings : ContentPage
    {
        public ObservableCollection<Colors> Colors { get; set; }
        public PageSettings()
        {
            InitializeComponent();
            Colors = new ObservableCollection<Colors> { 
                new Colors("Amarillo", "Color amar"), 
                new Colors("Rojo", "color roj"), 
                new Colors("Azul", "Color azul"),
                new Colors("Negro", "Color negro") 
            };
            ColoresPicker.ItemsSource = Colors;
            FondoPicker.ItemsSource = Colors;
            ColoresPicker.SelectedIndexChanged += ColorsPicker_SelectedIndexChanged;
            FondoPicker.SelectedIndexChanged += FondoPicker_SelectedIndexChanged;
            DarkModeCheckBox.CheckedChanged += DarkModeCheckBox_CheckedChanged;
        }

        private void DarkModeCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        { 
            if (DarkModeCheckBox.IsChecked)
            {
                (App.Current.MainPage as NavigationPage).BackgroundColor = Color.Black;
                (App.Current.MainPage as NavigationPage).BarTextColor = Color.White;
                (App.Current.MainPage as NavigationPage).BarBackgroundColor = Color.Gray;
                Colors.Clear();
                Colors.Add(new Colors("Ninguno", "No hay color"));
                ColoresPicker.ItemsSource = Colors;
                FondoPicker.ItemsSource = Colors;
                App.Current.Resources["Xamarin.Forms.Label"] = new Style(typeof(Label))
                {
                    Setters = {
                        new Setter { Property = Label.TextColorProperty,   Value = Color.White }
                    }

                };
                App.Current.Resources["Xamarin.Forms.Button"] = new Style(typeof(Button))
                {
                    Setters =
                    {
                        new Setter { Property = Button.BorderColorProperty, Value = Color.White},
                        new Setter { Property = Button.TextColorProperty, Value = Color.White}
                   
                    }
                };
                FondoPicker.Style = (Style)Application.Current.Resources["DarkPicker"];
                ColoresPicker.Style = (Style)Application.Current.Resources["DarkPicker"];
        
            }
            else{
                
                App.Current.Resources["Xamarin.Forms.Label"] = new Style(typeof(Label))
                {
                    Setters = {
                            new Setter { Property = Label.TextColorProperty,    Value = Color.Black }
                        }

                };


                (App.Current.MainPage as NavigationPage).BackgroundColor = Color.WhiteSmoke;
                (App.Current.MainPage as NavigationPage).BarTextColor = Color.Black;
                FondoPicker.Style = (Style)Application.Current.Resources["NormalPicker"];
                ColoresPicker.Style = (Style)Application.Current.Resources["NormalPicker"];
            }
        }


        private void FondoPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((FondoPicker.SelectedItem as Colors).Nombre)
            {
                case "Rojo":
                    (App.Current.MainPage as NavigationPage).BackgroundColor = Color.Red;
                    break;
                case "Amarillo":
                    (App.Current.MainPage as NavigationPage).BackgroundColor = Color.Yellow;
                    break;
                case "Azul":
                    (App.Current.MainPage as NavigationPage).BackgroundColor = Color.Blue;
                    break;
                case "Negro":
                    (App.Current.MainPage as NavigationPage).BackgroundColor = Color.Black;

                    break;
               
            }
        }



        private void ColorsPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((ColoresPicker.SelectedItem as Colors).Nombre)
            {
                case "Rojo":
                    (App.Current.MainPage as NavigationPage).BarBackgroundColor = Color.Red;
                    break;
                case "Amarillo":
                    (App.Current.MainPage as NavigationPage).BarBackgroundColor = Color.Yellow;
                    break;
                case "Azul":
                    (App.Current.MainPage as NavigationPage).BarBackgroundColor = Color.Blue;
                    break;
                case "Negro":
                    (App.Current.MainPage as NavigationPage).BarBackgroundColor = Color.Black;
                    break;
               
            }
        }


    }
}