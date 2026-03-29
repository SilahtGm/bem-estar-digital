
using MauiAppBemEstarDigital.Models;

namespace MauiAppBemEstarDigital.Views;



public partial class InsertLembretePage : ContentPage
{
	public InsertLembretePage()
	{
		InitializeComponent();
	}


    private async void Salvar_Clicked(object sender, EventArgs e)
    {
        try
        {
            //  Validações
            if (string.IsNullOrWhiteSpace(txt_titulo.Text))
            {
                await DisplayAlert("Erro", "Preencha o título", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_descricao.Text))
            {
                await DisplayAlert("Erro", "Preencha a descrição", "OK");
                return;
            }



            string titulo = txt_titulo.Text.Trim();
            string descricao = txt_descricao.Text.Trim();
            bool ativo = switchAtivo.IsToggled;

         
            var lembrete = new Lembrete
            {
                U_Id = App.UsuarioLogado.Id,
                Titulo = titulo,
                Descricao = descricao,
                Horario = timePickerHorario.Time,
                Ativo = ativo
            };

            //  Salvar
            await App.Db.InserirLembreteAsync(lembrete);
        

            //  Notificação
            if (lembrete.Ativo)
            {
                var service = new NotificacaoService();
                service.AgendarLembrete(lembrete);
            }

            await DisplayAlert("Sucesso", "Lembrete salvo!", "OK");
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }

   

}