namespace MauiAppBemEstarDigital.Views;

public partial class WelcomeMindHealthPage : ContentPage
{
	public WelcomeMindHealthPage()
	{
		InitializeComponent();
	}

    private void Navigation_MentalHealthPage(object sender, EventArgs e)
    {
        try
        {
            // Substitua "MentalHealthPage" pelo nome exato da sua página de destino
            Navigation.PushAsync(new Views.MindHealthPage());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}