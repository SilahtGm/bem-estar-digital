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

}