namespace MauiAppBemEstarDigital.Views;

using MauiAppBemEstarDigital.Models;

public partial class LembretesPage : ContentPage
{
	public LembretesPage()
	{
		InitializeComponent();
    }

    private void Novo_Lembrete_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Views.InsertLembretePage());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        var lista = await App.Db
            .ListarLembretesPorUsuarioAsync(App.UsuarioLogado.Id);

        collectionViewLembretes.ItemsSource = lista;

        var service = new NotificacaoService();

        // Sincronizar notificações
        foreach (var lembrete in lista)
        {
            if (lembrete.Ativo)
            {
                service.CancelarLembrete(lembrete.Id); // evita duplicar
                service.AgendarLembrete(lembrete);
            }
            else
            {
                service.CancelarLembrete(lembrete.Id);
            }
        }
    }

    private async void IsToggled(object sender, ToggledEventArgs e)
    {
        var sw = sender as Switch;
        var lembrete = sw?.BindingContext as Lembrete;

        lembrete.Ativo = e.Value;

        await App.Db.AtualizarLembreteAsync(lembrete);

        var service = new NotificacaoService();
    
        if (lembrete.Ativo == false)
        {
            service.CancelarLembrete(lembrete.Id);
        }
        else
        {
            service.AgendarLembrete(lembrete);
        }
    }

    private async void Excluir_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Pega o botão que disparou o evento
            var button = sender as Button;
            if (button == null)
                return;

            // Pega o Lembrete associado ao item do CollectionView
            var lembrete = button.BindingContext as Lembrete;
            if (lembrete == null)
                return;

            // Confirmação
            bool confirm = await DisplayAlert("Confirmar",
                "Deseja excluir este lembrete?",
                "Sim", "Não");
            if (!confirm)
                return;

            // Desativa e cancela notificação
            lembrete.Ativo = false;
            var service = new NotificacaoService();
            service.CancelarLembrete(lembrete.Id);

            // Remove do banco
            await App.Db.DeletarLembretePorIdAsync(lembrete.Id);

            // Atualiza a lista do CollectionView
            var lista = await App.Db.ListarLembretesPorUsuarioAsync(App.UsuarioLogado.Id);
            collectionViewLembretes.ItemsSource = lista;

            await DisplayAlert("Sucesso", "Lembrete deletado com sucesso!", "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }
    private async void Voltar_Clicked(object sender, EventArgs e)
    {

        try
        {
            await Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }

    }
}