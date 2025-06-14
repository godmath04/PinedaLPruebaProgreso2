﻿using System.Threading.Tasks;

namespace PinedaLPruebaProgreso2
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnChistes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChistesPage());
        }

        private async void OnAbout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }


    }

}
