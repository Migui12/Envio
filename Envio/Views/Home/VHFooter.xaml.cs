using Envio.Views.Home;
using Envio.Views.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envio.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VHFooter : ContentView
    {
        public VHFooter()
        {
            InitializeComponent();
        }

        private async void btn_iniciar_session_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VPPrincipal());
        }
    }
}