using Microsoft.Maui.ApplicationModel;

namespace MauiAppBemEstarDigital.Views;

public partial class MusicPage : ContentPage
{
    private readonly Dictionary<string, string> _youtubeLinks = new()
    {
        ["btnOndas"] = "https://youtu.be/V1bFr2SWP1I",
        ["btnChuva"] = "https://youtu.be/mPZkdNFkNps",
        ["btnPiano"] = "https://youtu.be/1ZYbU82GVz4",
        ["btnFloresta"] = "https://youtu.be/6zGQSWib32E",
        ["btnTigelas"] = "https://youtu.be/wGFog-OuFDM",
        ["btnNoite"] = "https://youtu.be/2OEL4P1Rz04",
        ["btnJazz"] = "https://youtu.be/DWcJFNfaw9c",
        ["btnVento"] = "https://youtu.be/eKFTSSKCzWA"
    };

    public MusicPage()
    {
        InitializeComponent();
    }

    private async void Musica_Clicked(object sender, EventArgs e)
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