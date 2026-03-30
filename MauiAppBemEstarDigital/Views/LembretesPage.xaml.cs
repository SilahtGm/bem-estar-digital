namespace MauiAppBemEstarDigital.Views;
using MauiAppBemEstarDigital.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

public partial class LembretesPage : ContentPage
{
    private ObservableCollection<Lembrete> lista = new ObservableCollection<Lembrete>();

    public LembretesPage()
    {
        InitializeComponent();
        collectionViewLembretes.ItemsSource = lista;
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
        lista.Clear();

        var lembretesDoBanco = await App.Db.ListarLembretesPorUsuarioAsync(App.UsuarioLogado.Id);

        lembretesDoBanco.ForEach(l => lista.Add(l));
    }

    private async void IsToggled(object sender, ToggledEventArgs e)
    {
        var sw = sender as Switch;
        var lembrete = sw?.BindingContext as Lembrete;
        if (lembrete == null) return;

        lembrete.Ativo = e.Value;
        await App.Db.AtualizarLembreteAsync(lembrete);

        var service = new NotificacaoService();
        if (lembrete.Ativo)
        {
            service.AgendarLembrete(lembrete);
           

        }
        else
        {
            service.CancelarLembrete(lembrete.Id);
            
        }

    }

    private async void Excluir_Clicked(object sender, EventArgs e)
    {
        try
        {
            var button = sender as Button;
            Lembrete l = button.BindingContext as Lembrete;

            // Confirmação
            bool confirm = await DisplayAlert("Confirmar",
                "Deseja excluir este lembrete?",
                "Sim", "Não");

            if (confirm) {

                // Cancelar notificação antes de excluir
                var service = new NotificacaoService();
                service.CancelarLembrete(l.Id);

                // Deletar do banco e atualizar a lista
                await App.Db.DeletarLembretePorIdAsync(l.Id);
                lista.Remove(l);
                await DisplayAlert("Removido", "Lembrete excluído com sucesso!", "OK");

            }
            
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

    private async void TimePicker_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "Time")
        {
            var timePicker = sender as TimePicker;
            var lembrete = timePicker?.BindingContext as Lembrete;

            if (lembrete == null) return;

            var service = new NotificacaoService();

            service.CancelarLembrete(lembrete.Id);

            await App.Db.AtualizarLembreteAsync(lembrete);

            service.AgendarLembrete(lembrete);
        }
    }
}