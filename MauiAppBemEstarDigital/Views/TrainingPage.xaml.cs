using System.Collections.Generic;

namespace MauiAppBemEstarDigital.Views;

public partial class TrainingPage : ContentPage
{
    public class Treino
    {
        public string Nome { get; set; }
        public string Series { get; set; }
        public string Repeticoes { get; set; }
        public string Cuidados { get; set; }
    }

    Dictionary<string, List<Treino>> treinos;

    public TrainingPage()
    {
        InitializeComponent();

        treinos = new Dictionary<string, List<Treino>>
        {
            ["Emagrecimento"] = new List<Treino>
            {
                new Treino
                {
                    Nome = "Caminhada rápida",
                    Series = "3 sessões",
                    Repeticoes = "15 a 20 minutos",
                    Cuidados = "Mantenha hidratação e respeite seu ritmo."
                },
                new Treino
                {
                    Nome = "Agachamento livre",
                    Series = "3 séries",
                    Repeticoes = "12 repetições",
                    Cuidados = "Evite curvar a coluna."
                },
                new Treino
                {
                    Nome = "Polichinelos",
                    Series = "3 séries",
                    Repeticoes = "20 segundos",
                    Cuidados = "Interrompa se houver desconforto."
                }
            },

            ["Ganho de Massa"] = new List<Treino>
            {
                new Treino
                {
                    Nome = "Flexão de braço",
                    Series = "3 séries",
                    Repeticoes = "8 a 12 repetições",
                    Cuidados = "Mantenha postura alinhada."
                },
                new Treino
                {
                    Nome = "Agachamento",
                    Series = "4 séries",
                    Repeticoes = "10 repetições",
                    Cuidados = "Faça movimentos controlados."
                },
                new Treino
                {
                    Nome = "Prancha",
                    Series = "3 séries",
                    Repeticoes = "20 segundos",
                    Cuidados = "Não force lombar."
                }
            },

            ["Treino em Casa"] = new List<Treino>
            {
                new Treino
                {
                    Nome = "Agachamento",
                    Series = "3 séries",
                    Repeticoes = "12 repetições",
                    Cuidados = "Mantenha os joelhos alinhados."
                },
                new Treino
                {
                    Nome = "Abdominal simples",
                    Series = "3 séries",
                    Repeticoes = "15 repetições",
                    Cuidados = "Evite puxar o pescoço."
                },
                new Treino
                {
                    Nome = "Prancha",
                    Series = "3 séries",
                    Repeticoes = "20 segundos",
                    Cuidados = "Respeite seu limite."
                }
            },

            ["Cardio"] = new List<Treino>
            {
                new Treino
                {
                    Nome = "Caminhada",
                    Series = "1 sessão",
                    Repeticoes = "20 minutos",
                    Cuidados = "Use calçado confortável."
                },
                new Treino
                {
                    Nome = "Corrida leve",
                    Series = "1 sessão",
                    Repeticoes = "10 minutos",
                    Cuidados = "Pare em caso de tontura."
                },
                new Treino
                {
                    Nome = "Bicicleta ergométrica",
                    Series = "1 sessão",
                    Repeticoes = "15 minutos",
                    Cuidados = "Mantenha intensidade moderada."
                }
            },

            ["Alongamento"] = new List<Treino>
            {
                new Treino
                {
                    Nome = "Alongamento de pernas",
                    Series = "2 séries",
                    Repeticoes = "20 segundos",
                    Cuidados = "Sem movimentos bruscos."
                },
                new Treino
                {
                    Nome = "Alongamento de braços",
                    Series = "2 séries",
                    Repeticoes = "20 segundos",
                    Cuidados = "Não force articulações."
                },
                new Treino
                {
                    Nome = "Mobilidade cervical",
                    Series = "2 séries",
                    Repeticoes = "10 movimentos leves",
                    Cuidados = "Movimentos lentos."
                }
            },

            ["Funcional"] = new List<Treino>
            {
                new Treino
                {
                    Nome = "Agachamento",
                    Series = "3 séries",
                    Repeticoes = "12 repetições",
                    Cuidados = "Mantenha postura correta."
                },
                new Treino
                {
                    Nome = "Prancha",
                    Series = "3 séries",
                    Repeticoes = "20 segundos",
                    Cuidados = "Evite sobrecarga lombar."
                },
                new Treino
                {
                    Nome = "Elevação de joelhos",
                    Series = "3 séries",
                    Repeticoes = "15 repetições",
                    Cuidados = "Faça no seu ritmo."
                }
            }
        };
    }

    private void pickerTreinos_SelectedIndexChanged(object sender, EventArgs e)
    {
        string treinoSelecionado =
            pickerTreinos.SelectedItem?.ToString();

        if (!string.IsNullOrEmpty(treinoSelecionado)
            && treinos.ContainsKey(treinoSelecionado))
        {
            collectionTreinos.ItemsSource =
                treinos[treinoSelecionado];
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