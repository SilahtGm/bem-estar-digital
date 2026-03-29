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

                // Limpa o usuário logado
                App.UsuarioLogado = null;

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
            CarregarHistoricoIMC();

        }

        // Método histórico de IMC
        private async void CarregarHistoricoIMC()
        {
            try
            {
                // Pega todos os registros do usuário logado
                var historico = await App.Db.GetHistoricoIMCAsync(App.UsuarioLogado.Id);

                // Atribui à CollectionView
                cvHistoricoIMC.ItemsSource = historico;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }


        private void Imc_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Views.InsertIMC());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CarregarHistoricoIMC(); // Sempre recarrega os registros
        }



    }
}