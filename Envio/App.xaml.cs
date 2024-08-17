using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Envio.Views.Home;
using Envio.Views.Producto;
using Envio.Views.Figma;

namespace Envio
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new VHPrincipal());
            //MainPage = new VPPrincipal();
            MainPage = new VFPrincipal();
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
