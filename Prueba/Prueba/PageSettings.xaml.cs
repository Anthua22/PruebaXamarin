using Prueba.Entidades;
using Prueba.Interfaces;
using Prueba.Servicio;
using Prueba.Utilidades;
using SQLite;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSettings : ContentPage
    {
        public ObservableCollection<DTOColor> BackgroundColors { get; set; }
        public ObservableCollection<DTOColor> BackgroundBar { get; set; }
        //private SQLiteAsyncConnection _conn;

        public PageSettings()
        {
            InitializeComponent();
            BackgroundColors = new ObservableCollection<DTOColor> { 
                new DTOColor("Amarillo", "Color amar"), 
                new DTOColor("Rojo", "color roj"), 
                new DTOColor("Azul", "Color azul"),
                new DTOColor("Negro", "Color negro") 
            };
           // _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            BackgroundBar = new ObservableCollection<DTOColor>
            {
                new DTOColor("Amarillo", "Color amar"),
                new DTOColor("Rojo", "color roj"),
                new DTOColor("Azul", "Color azul"),
                new DTOColor("Negro", "Color negro")
            };
            ColoresPicker.ItemsSource = BackgroundBar;
            FondoPicker.ItemsSource = BackgroundColors;
            ColoresPicker.SelectedIndexChanged += ColorsPicker_SelectedIndexChanged;
            FondoPicker.SelectedIndexChanged += FondoPicker_SelectedIndexChanged;
            DarkModeCheckBox.CheckedChanged += DarkModeCheckBox_CheckedChanged;
            AddCheck();
        }

        private void AddCheck()
        {
            try
            {
                string mode = DependencyService.Get<IFileHelper>().CheckMode();
                if (mode == "ON")
                {
                    DarkModeCheckBox.IsChecked = true;                
                }
                else
                {
                    DarkModeCheckBox.IsChecked = false;
                   
                }
            }catch(Exception e)
            {
                DisplayAlert("Error", "Error: " + e.Message, "OK");
            }
           
        }

        private void DarkModeCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try
            {
                if (DarkModeCheckBox.IsChecked)
                {
                    Pickers.IsVisible = false;
                    ChangesColors.ChangeToDark();
                    
                }
                else
                {
                    Pickers.IsVisible = true;
                    ChangesColors.ChangeToDefault();

                }
                DependencyService.Get<IFileHelper>().ChangeMode(DarkModeCheckBox.IsChecked);
               // var db = new SQLiteConnection(DependencyService.Get<IFileHelper>().GetFile());
               // DataBase.Update(db, DarkModeCheckBox.IsChecked,1);
            }
            catch(Exception ex)
            {
                DisplayAlert("Error", "Error: " + ex.Message, "OK");
            }
            
            
        }

        private void FondoPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((FondoPicker.SelectedItem as DTOColor).Nombre)
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
                default:
                    break;
               
            }
        }

        private void ColorsPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((ColoresPicker.SelectedItem as DTOColor).Nombre)
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