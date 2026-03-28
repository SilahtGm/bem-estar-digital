using System;
using System.Collections.Generic;
using MauiAppBemEstarDigital.Models;
using Microsoft.Maui.Controls;

namespace MauiAppBemEstarDigital.Views
{
    public partial class HomePage : ContentPage
    {

        private void LogOut_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Views.LoginPage());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
        public HomePage()
        {
            InitializeComponent();
           
        }

      

        

       
    }
}