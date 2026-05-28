
using MauiAppBemEstarDigital.Models;
using System.Text;

namespace MauiAppBemEstarDigital.Views;

public partial class MindHealthPage : ContentPage
{


    private string _emojiSelecionado = "";
    public MindHealthPage()
    {
        InitializeComponent();

        VerificarHumorDoDia();
        CarregarHistorico();
    }

    private async void Humor_Clicked(object sender, EventArgs e)
    {

         String ObterEmojiSelecionado() => _emojiSelecionado;


        bool jaRegistrou = await App.Db.UsuarioJaRegistrouHumorHojeAsync(App.UsuarioLogado.Id);

        if (jaRegistrou)
        {
            await DisplayAlert("Registro diário", "Você já registrou seu humor hoje", "OK");
            return;
        }

        string emoji = ObterEmojiSelecionado();

        if (string.IsNullOrEmpty(emoji))
        {
            await DisplayAlert("Atenção", "Selecione um emoji primeiro ??", "OK");
            return;
        }

        string descricao = txtDescricaoHumor.Text?.Trim() ?? "";

        Humor humor = new Humor
        {
            U_Id = App.UsuarioLogado.Id,
            Emoji = emoji,
            Descricao = descricao,
            Data_humor = DateTime.Now
        };

        await App.Db.InserirHumorAsync(humor);
        CarregarHistorico();

        await DisplayAlert("Sucesso", "Humor registrado com sucesso!", "OK");
        BloquearHumor();
    }



    

    private void SelecionarHumor_Clicked(object sender, EventArgs e)
    {
        Button botao = (Button)sender;
        _emojiSelecionado = botao.Text;
        lblStatusHumor.Text = $"Humor selecionado: {_emojiSelecionado}";
    }




    private async void VerificarHumorDoDia()
    {
        bool jaRegistrou =
            await App.Db
            .UsuarioJaRegistrouHumorHojeAsync(
                App.UsuarioLogado.Id);

        if (jaRegistrou)
        {
            lblStatusHumor.Text =
                "Você já registrou seu humor hoje";

            BloquearHumor();
        }
        else
        {
            lblStatusHumor.Text =
                "Escolha como está se sentindo hoje";
        }
    }

    private void BloquearHumor()
    {
        btnTriste.IsEnabled = false;
        btnNormal.IsEnabled = false;
        btnFeliz.IsEnabled = false;
        btnMuitoFeliz.IsEnabled = false;

        btnTriste.Opacity = 0.5;
        btnNormal.Opacity = 0.5;
        btnFeliz.Opacity = 0.5;
        btnMuitoFeliz.Opacity = 0.5;
    }

    private async void CarregarHistorico()
    {
        try
        {
            var historico =
                await App.Db
                .ListarHumorPorUsuarioAsync(
                    App.UsuarioLogado.Id);

            collectionHistorico.ItemsSource =
                historico;
        }
        catch (Exception ex)
        {
            await DisplayAlert(
                "Erro",
                ex.Message,
                "OK");
        }
    }

    private void Voltar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HomePage());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}