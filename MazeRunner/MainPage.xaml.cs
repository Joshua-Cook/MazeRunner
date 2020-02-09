using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Slider.Value = 0.5;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            DisplayAlert("Tilte", "The new " + Button.Text, "OK");
        }

        
    }
}
