using System;
using System.Collections.Generic;
using MauiAppBemEstarDigital.Models;
using Microsoft.Maui.Controls;

namespace MauiAppBemEstarDigital.Views
{
    public partial class HomePage : ContentPage
    {

        private async void LogOut_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Pergunta ao usuário se tem certeza
                bool confirmar = await DisplayAlert(
                    "Sair",
                    "Tem certeza que deseja sair da conta?",
                    "Sim",
                    "Não"
                );

                if (confirmar)
                {
                    // Limpa o usuário logado
                    App.UsuarioLogado = null;

                    // Volta para a LoginPage
                    await Navigation.PushAsync(new Views.LoginPage());
                }
                // Se o usuário clicar em "Não", nada acontece
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        public HomePage()
        {
            InitializeComponent();
            CarregarHistoricoIMC();
            MostrarDicaAleatoria();

        }

        // Método histórico de IMC
        private async void CarregarHistoricoIMC()
        {
            try
            {
                // Pega todos os registros do usuário logado
                var historico = await App.Db.GetHistoricoIMCAsync(App.UsuarioLogado.Id);

                // Atribui à CollectionView
                cvHistoricoIMC.ItemsSource = historico;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }


        private void Imc_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Views.WelcomeInsertIMC());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Lembretes_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Views.WelcomeLembretesPage());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CarregarHistoricoIMC(); // Sempre recarrega os registros
            lblSaudacao.Text = ObterSaudacao();
        }

        public string ObterSaudacao()
        {
            int horaAtual = DateTime.Now.Hour;

            if (horaAtual >= 6 && horaAtual < 12)
                return "Olá, Bom dia!";

            if (horaAtual >= 12 && horaAtual < 18)
                return "Olá, Boa tarde!";

            return "Olá, Boa noite!";
        }


        private void Navigation_SaudeMental (object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Views.WelcomeMindHealthPage());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }


        private void Navigation_DietPage (object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Views.DietPage());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Navigation_TrainingPage(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Views.TrainingPage());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Navigation_HydrationPage(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Views.WelcomeHydrationPage());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }










        private readonly Random _random = new();

        private readonly List<string> _dicas = new()
    {
       "Organizar seu espaço de trabalho ajuda a clarear a mente.",
"Escrever suas tarefas no papel diminui a ansiedade diária.",
"Alongar o corpo pela manhã desperta a energia para o resto do dia.",
"Comer frutas frescas no café da manhã melhora a sua disposição.",
"Praticar a gratidão diariamente muda sua perspectiva de vida.",
"Dizer 'não' para o que te esgota é um importante ato de autocuidado.",
"Manter uma postura correta previne dores e cansaço ao longo do dia.",
"Sorrir mais ajuda a liberar hormônios ligados ao bem-estar.",
"Trocar o celular por um livro à noite acelera o processo de relaxamento.",
"Focar em uma tarefa por vez aumenta muito a sua produtividade.",
"Cultivar plantas em casa traz mais tranquilidade ao ambiente.",
"Cozinhar a própria refeição pode ser uma ótima forma de terapia.",
"Desligar as notificações do celular durante o trabalho evita distrações.",
"Aprender algo novo todos os dias mantém o seu cérebro jovem e ativo.",
"Substituir o café por chá no fim da tarde ajuda na qualidade do sono.",
"Fazer uma lista de prioridades evita a sensação de sobrecarga mental.",
"Meditar por apenas 5 minutos já é o suficiente para acalmar a mente.",
"Manter contato com amigos queridos nutre a sua saúde emocional.",
"Substituir queixas por soluções agiliza a resolução de problemas.",
"Caminhar descalço na grama ou areia ajuda a descarregar a tensão.",
"Reduzir o consumo de açúcar melhora a sua clareza mental e energia.",
"Ter um hobby criativo fora do trabalho reduz o estresse do dia a dia.",
"Estabelecer horários fixos para deitar ajuda a regular o relógio biológico.",
"Beber um copo de água logo ao acordar reidrata o corpo rapidamente.",
"Ajudar alguém sem esperar nada em troca eleva instantaneamente o ânimo.",
"Limitar o tempo nas redes sociais diminui a comparação e a ansiedade.",
"Respirar fundo antes de responder a uma situação difícil evita estresse.",
"Planejar o dia seguinte na noite anterior poupa tempo e energia de manhã.",
"Subir escadas em vez de usar o elevador já conta como um bom exercício.",
"Aceitar que nem tudo sai perfeito ajuda a manter a sua paz interior."
    };

       
           

        private void MostrarDicaAleatoria()
        {
            int indice = _random.Next(_dicas.Count);

            lblDica.Text = _dicas[indice];
        }

       
    }
}