namespace MauiAppBemEstarDigital.Views;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}

    private void Navigation_clicked(object sender, EventArgs e)
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
}