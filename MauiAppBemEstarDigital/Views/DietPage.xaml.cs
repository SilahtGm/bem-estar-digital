namespace MauiAppBemEstarDigital.Views;

public partial class DietPage : ContentPage
{
	public DietPage()
	{
		InitializeComponent();
	}

    private void Voltar_Clicked(object sender, EventArgs e)
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