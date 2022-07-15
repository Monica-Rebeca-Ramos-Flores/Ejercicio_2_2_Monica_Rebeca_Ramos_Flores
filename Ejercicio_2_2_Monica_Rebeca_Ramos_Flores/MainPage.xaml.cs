using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignaturePad.Forms;
using Xamarin.Forms;

namespace Ejercicio_2_2_Monica_Rebeca_Ramos_Flores
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            Stream image = await PadView.GetImageStreamAsync(SignaturePad.Forms.SignatureImageFormat.Jpeg);
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            PadView.Clear();
        }
    }
}
