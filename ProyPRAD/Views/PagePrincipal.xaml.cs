using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyPRAD.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyPRAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private async void btn_contatos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageContactos());
        }

        private async void btn_places_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TBPageContactos());
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnsitiod_Clicked(object sender, EventArgs e)
        {

        }
    }
}