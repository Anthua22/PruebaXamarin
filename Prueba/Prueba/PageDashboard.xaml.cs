using Prueba.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<DTOAppoinment> ItemsList { get; set; }
        public PageDashboard()
        {
            InitializeComponent();
            ItemsList = MakeItems();
            lvAppoinments.ItemsSource = ItemsList;

            

        }

        private ObservableCollection<DTOAppoinment> MakeItems()
        {
            ObservableCollection<DTOAppoinment> items = new ObservableCollection<DTOAppoinment>();
            DTOAppoinment dTOAppoinment = new DTOAppoinment("Calle Aspe", "Alicante", "03010", "Alicante", DateTime.Now);
            dTOAppoinment.TemplatePicker();
            DTOAppoinment item2 = new DTOAppoinment("Avenida Mainsonave", "Alicante", "03251", "Alicante", DateTime.Now);
            item2.TemplatePicker();
            DTOAppoinment item3 = new DTOAppoinment("Calle Picasso", "San Vicente", "03036", "Alicante", DateTime.Now);       
            item3.TemplatePicker();
            DTOAppoinment item4 = new DTOAppoinment("Calle Poeta Sansano", "Alicante", "03010", "Alicante", DateTime.Now);
            item4.TemplatePicker();
            DTOAppoinment item5 = new DTOAppoinment("Avenida Alfonso el Sabio", "Alicante", "03012", "Alicante", DateTime.Now);
            item5.TemplatePicker();
            DTOAppoinment item6 = new DTOAppoinment("Calle Siempre Viva", "San Juan", "03025", "Alicante", DateTime.Now);
            item6.TemplatePicker();
            DTOAppoinment item7 = new DTOAppoinment("Calle Maldonado", "Cullera", "04010", "Valencia", DateTime.Now);
            item7.TemplatePicker();
            items.Add(dTOAppoinment);
            items.Add(item2);
            items.Add(item3);
            items.Add(item4);
            items.Add(item5);
            items.Add(item6);
            items.Add(item7);
            return items;
            
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