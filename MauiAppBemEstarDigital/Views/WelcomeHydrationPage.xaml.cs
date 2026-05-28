namespace MauiAppBemEstarDigital.Views;

public partial class WelcomeHydrationPage : ContentPage
{
	public WelcomeHydrationPage()
	{
		InitializeComponent();
	}

    private void Navigation_HydrationPage(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Views.HydrationPage());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}