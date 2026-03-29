using Plugin.LocalNotification;
using MauiAppBemEstarDigital.Models;

public class NotificacaoService
{

    
    public void AgendarLembrete(Lembrete lembrete)
    {
        if (!lembrete.Ativo)
            return;

        var agora = DateTime.Now;
        var horario = DateTime.Today.Add(lembrete.Horario);

        // Se a hora já passou hoje, agenda para amanhã
        if (horario <= agora)
        {
            horario = horario.AddDays(1);
        }

        var notification = new NotificationRequest
        {
            NotificationId = lembrete.Id,
            Title = lembrete.Titulo,
            Description = lembrete.Descricao,
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = horario, // horário do lembrete
                RepeatType = NotificationRepeat.Daily // para repetir diariamente no mesmo horário
            }
        };

        LocalNotificationCenter.Current.Show(notification); // Agenda a notificação
    }
        
    public void CancelarLembrete(int id)
    {
        LocalNotificationCenter.Current.Cancel(id); // Cancela a notificação pelo ID
    }
}