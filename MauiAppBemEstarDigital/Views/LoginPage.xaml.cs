using MauiAppBemEstarDigital.Models;

namespace MauiAppBemEstarDigital.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void Criar_Conta_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Views.SignUpPage());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        // Pega os valores dos Entry
        string email = txt_email.Text?.Trim();
        string senha = txt_senha.Text;

        if (email == null || senha == null)
        {
            await DisplayAlert("Erro", "Por favor, preencha email e senha.", "OK");
            return;
        }

        // Chama o método de login
        Usuario usuario = await App.Db.LoginAsync(email, senha);

        if (usuario != null)
        {
            // Login bem-sucedido
            await DisplayAlert("Sucesso", "Login realizado!", "OK");

            // Navegar para a página principal (ex: HomePage)
            await Navigation.PushAsync(new HomePage());
        }
        else
        {
            // Falha no login
            await DisplayAlert("Erro", "Email ou senha incorretos.", "OK");
        }
    }

}