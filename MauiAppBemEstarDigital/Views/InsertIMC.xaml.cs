using MauiAppBemEstarDigital.Models;
using System;
using Microsoft.Maui.Controls;

namespace MauiAppBemEstarDigital.Views;

public partial class InsertIMC : ContentPage
{
	public InsertIMC()
	{
		InitializeComponent();
	}


    private async void Registrar_Clicked(object sender, EventArgs e)
    {
        try
        {

            if (txt_peso.Text == null || txt_peso.Text == "")
                throw new Exception("Preencha o peso");
            if (slider_altura.Value < slider_altura.Minimum || slider_altura.Value > slider_altura.Maximum)
                throw new Exception("Altura inválida");
            if (txt_idade.Text == null || txt_idade.Text == "")
                throw new Exception("Preencha a idade");

            // Converte os valores
            double peso = Convert.ToDouble(txt_peso.Text);   
            double altura = slider_altura.Value;            
            int idade = Convert.ToInt32(txt_idade.Text);    
            


            // Calcula o IMC
            double imc = peso / (altura * altura);

            // Define o status 
            string status = "";

            if (imc < 16)
                status = "Baixo peso grave";
            else if (imc >= 16 && imc < 17)
                status = "Baixo peso moderado";
            else if (imc >= 17 && imc < 18.5)
                status = "Baixo peso leve";
            else if (imc >= 18.5 && imc < 25)
                status = "Peso normal";
            else if (imc >= 25 && imc < 30)
                status = "Sobrepeso";
            else if (imc >= 30 && imc < 35)
                status = "Obesidade Grau I";
            else if (imc >= 35 && imc < 40)
                status = "Obesidade Grau II";
            else
                status = "Obesidade Grau III";

            // Cria o objeto para inserir no banco
            var registro = new PesoUsuario
            {
                U_Id = App.UsuarioLogado.Id, // usuário logado
                Status = status,
                Peso = peso,
                Altura = altura,
                Idade = idade,
                IMC = imc,
                Data = DateTime.Now
            };

            await App.Db.InserirPesoAsync(registro);

            await DisplayAlert("Sucesso", "Registro inserido com sucesso!", "OK");

            // Volta para a HomePage
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }

    private void Cancelar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Views.HomePage());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK"); 
        }
    }

    private void Slider_Altura_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double altura = e.NewValue; // Atualiza o valor da altura com o valor do slider
        lblAltura.Text = $"Altura: {altura:F2} m"; // Exibe a altura com 2 casas decimais
    }
}