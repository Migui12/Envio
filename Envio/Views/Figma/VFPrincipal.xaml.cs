using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Envio.Views.Producto;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envio.Views.Figma
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VFPrincipal : ContentPage
    {
        public VFPrincipal()
        {
            InitializeComponent();
        }

        private async void btn_iniciar_session_Clicked(object sender, EventArgs e)
        {
            string usuario = "admin";
            string pass = "admin";

            string usuario_ingresado = txtvalor1.Text;
            string contraseña_ingresado = txtvalor2.Text;

            if(usuario == usuario_ingresado && pass == contraseña_ingresado)
            {
                await Navigation.PushModalAsync(new VPPrincipal());
            }
            else
            {
                lblResultado.Text = "Incorrecto!!";
            }
        }
    }
}