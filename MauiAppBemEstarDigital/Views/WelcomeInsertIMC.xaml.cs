namespace MauiAppBemEstarDigital.Views;

public partial class WelcomeInsertIMC : ContentPage
{
	public WelcomeInsertIMC()
	{
		InitializeComponent();
	}

    private void Navigation_ImcPage(object sender, EventArgs e)
    {
        try
        {
            // Substitua 'Views.ImcCalculatorPage' pelo nome real da página
            // para onde você quer navegar quando o usuário clicar no botão.
            Navigation.PushAsync(new Views.InsertIMC());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}