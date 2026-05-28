namespace MauiAppBemEstarDigital.Views;

public partial class HydrationPage : ContentPage
{
    public HydrationPage()
    {
        InitializeComponent();
    }

    private async void Calcular_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtPeso.Text))
        {
            await DisplayAlert(
                "Atenção",
                "Digite seu peso.",
                "OK");

            return;
        }

        bool pesoValido =
            double.TryParse(
                txtPeso.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out double peso);

        if (!pesoValido || peso <= 0)
        {
            await DisplayAlert(
                "Erro",
                "Digite um peso válido.",
                "OK");

            return;
        }

        // 35ml por kg
        double ml = peso * 35;

        // Converter para litros
        double litros = ml / 1000;

        lblResultado.Text =
            $"{litros:F1} litros por dia";

        lblMensagem.Text =
            "Manter uma boa hidratação ajuda na concentração, energia e bem-estar!";

        resultadoCard.IsVisible = true;
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