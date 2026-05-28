namespace MauiAppBemEstarDigital.Views;

public partial class WelcomeLembretesPage : ContentPage
{
	public WelcomeLembretesPage()
	{
		InitializeComponent();
	}


    private void Navigation_LembretesPage(object sender, EventArgs e)
    {
        try
        {
          
            Navigation.PushAsync(new Views.LembretesPage());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}