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

}