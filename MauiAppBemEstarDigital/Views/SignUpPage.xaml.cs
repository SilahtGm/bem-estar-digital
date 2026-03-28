using MauiAppBemEstarDigital.Models;

namespace MauiAppBemEstarDigital.Views;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}
    private void Login_Clicked(object sender, EventArgs e)
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


    private async void RegistrarButton_Clicked(object sender, EventArgs e)
    {
        string email = txt_email.Text?.Trim();
        string senha = txt_senha.Text;
        string confirma = txt_confirma_senha.Text;

        if (email == null ||senha == null)
        {
            await DisplayAlert("Erro", "Preencha todos os campos", "OK");
            return;
        }

        if (senha != confirma)
        {
            await DisplayAlert("Erro", "As senhas não conferem", "OK");
            return;
        }

        var novoUsuario = new Usuario
        {
            Email = email,
            Senha = senha
        };

        bool sucesso = await App.Db.CriarContaAsync(novoUsuario);

        if (sucesso)
        {
            await DisplayAlert("Sucesso", "Conta criada com sucesso!", "OK");
            await Navigation.PopAsync(); 
        }
        else
        {
            await DisplayAlert("Erro", "Já existe uma conta com esse email.", "OK");
        }
    }

}