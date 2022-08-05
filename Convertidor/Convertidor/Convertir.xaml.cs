using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Convertidor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double valor;
        double pesoMx;
        double libraEst;
        double euro;
        double solPeruano;
        double Yen;

        public Convertir()
        {
            InitializeComponent();
        }

        public void Calcular() {
            valor = Convert.ToDouble(PesosEntry.Text);
            euro = valor * 0.98;
            solPeruano = valor * 3.90;
            pesoMx = valor * 20.33;
            libraEst = valor * 0.82;
            Yen = valor * 133.563;

            reslbl1.Text = euro.ToString() +" Euro";
            reslbl2.Text = libraEst.ToString() + " Libra esterlina";
            reslbl3.Text = pesoMx.ToString() + " Peso Mexicano";
            reslbl4.Text = solPeruano.ToString() + " Sol peruano";
            reslbl5.Text = Yen.ToString() + " Yen Jp";



        }

        void Limpiar()
        {
            PesosEntry.Text = string.Empty;
            reslbl1.Text = string.Empty;
            reslbl2.Text = string.Empty;
            reslbl3.Text = string.Empty;
            reslbl4.Text = string.Empty;
            reslbl5.Text = string.Empty;


        }





        private void validar() {
            if (!string.IsNullOrEmpty(PesosEntry.Text)) { 
                Calcular();
            } 
            else 
            { 
                DisplayAlert("Error", "Ingrese una cantidad","OK"); }
        }
        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            //Navigation.PopAsync();
            Navigation.PushAsync(new MainPage());
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            validar();
        }

        private void LimpiarButton_Clicked(object sender, EventArgs e)
        {
            Limpiar();
        }



    }
}