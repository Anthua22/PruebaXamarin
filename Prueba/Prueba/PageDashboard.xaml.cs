using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDashboard : ContentPage
    {
        public PageDashboard()
        {
            InitializeComponent();
            
        }

        private void ColoresItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageSettings());
        }
        private void CierreItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            
        }
    }
}