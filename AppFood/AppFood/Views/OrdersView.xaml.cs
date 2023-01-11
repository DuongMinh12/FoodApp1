﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersView : ContentPage
    {
        public OrdersView( string id)
        {
            InitializeComponent();
            LabelName.Text = "Bienvenu" + Preferences.Get("Username", "Guest") + ",";
            LabelOrderID.Text = id;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void viewProduct_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProductPage());
        }
    }
}