using Microsoft.Maui.ApplicationModel;

namespace MauiAppBemEstarDigital.Views;

public partial class MeditationPage : ContentPage
{
    private readonly Dictionary<string, string> _youtubeLinks = new()
    {
        ["btnIniciantes"] = "https://youtu.be/inpok4MKVLM",
        ["btnDormir"] = "https://youtu.be/aEqlQvczMJQ",
        ["btnFoco"] = "https://youtu.be/syx3a1PBsec",
        ["btnAnsiedade"] = "https://youtu.be/O-6f5wQXSu8",
        ["btnAmor"] = "https://youtu.be/sz7cpV7ERsM",
        ["btnRespiracao"] = "https://youtu.be/tybOi4hjZFQ",
        ["btnNatureza"] = "https://youtu.be/1vx8iUvfyCY",
        ["btnEnergia"] = "https://youtu.be/86m4RC_ADEY"
    };

    public MeditationPage()
    {
        InitializeComponent();
    }

    private async void Meditacao_Clicked(object sender, EventArgs e)
    {
        Button botao = (Button)sender;
        if (_youtubeLinks.TryGetValue(botao.StyleId, out string url))
        {
            await Launcher.Default.OpenAsync(url);
        }
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}