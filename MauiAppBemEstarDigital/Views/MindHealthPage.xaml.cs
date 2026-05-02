namespace MauiAppBemEstarDigital.Views;

public partial class MindHealthPage : ContentPage
{
	public MindHealthPage()
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