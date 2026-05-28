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
                Series = "3 sessões por semana",
                Repeticoes = "20 a 30 minutos por sessão",
                Cuidados = "Mantenha hidratação antes, durante e após. Aumente o tempo progressivamente a cada semana. Use calçado adequado para evitar lesões nos joelhos e tornozelos."
            },
            new Treino
            {
                Nome = "Agachamento livre",
                Series = "3 séries",
                Repeticoes = "15 repetições",
                Cuidados = "Evite curvar a coluna — mantenha o peito aberto e olhar para frente. Desça até a linha das coxas ficar paralela ao chão. Joelhos não devem ultrapassar a ponta dos pés em excesso."
            },
            new Treino
            {
                Nome = "Polichinelos (Jumping Jacks)",
                Series = "4 séries",
                Repeticoes = "30 segundos com 15s de descanso",
                Cuidados = "Interrompa imediatamente em caso de desconforto no peito ou tontura. Ótimo para elevar a frequência cardíaca rapidamente. Pode ser substituído por caminhada no lugar para iniciantes."
            },
            new Treino
            {
                Nome = "Burpee modificado",
                Series = "3 séries",
                Repeticoes = "8 a 10 repetições",
                Cuidados = "Para iniciantes, retire o salto final. Mantenha o abdômen contraído durante todo o movimento. Descanse 60 segundos entre as séries. Exercício de alta eficiência calórica."
            },
            new Treino
            {
                Nome = "Mountain climber",
                Series = "3 séries",
                Repeticoes = "20 segundos contínuos",
                Cuidados = "Mantenha o quadril estável e o abdômen contraído. Evite elevar ou afundar os quadris. Excelente para queima calórica e fortalecimento do core simultaneamente."
            },
            new Treino
            {
                Nome = "Pulo de corda (ou simulado)",
                Series = "3 sessões",
                Repeticoes = "1 minuto por sessão",
                Cuidados = "Se não tiver corda, simule o movimento no lugar. Pouse sempre na ponta dos pés para amortecer o impacto. Evite se tiver problemas nos joelhos ou tornozelos sem orientação médica."
            },
            new Treino
            {
                Nome = "Prancha com variação",
                Series = "3 séries",
                Repeticoes = "20 a 30 segundos",
                Cuidados = "Alterne entre prancha frontal e lateral para trabalhar todo o core. Não prenda a respiração. Aumente gradualmente o tempo de sustentação ao longo das semanas."
            }
        },

            ["Ganho de Massa"] = new List<Treino>
        {
            new Treino
            {
                Nome = "Flexão de braço",
                Series = "4 séries",
                Repeticoes = "8 a 12 repetições",
                Cuidados = "Mantenha postura alinhada — corpo reto da cabeça ao calcanhar. Para iniciantes, apoie os joelhos. Varie as posições das mãos: aberta (peitoral), fechada (tríceps), ou inclinada."
            },
            new Treino
            {
                Nome = "Agachamento com carga",
                Series = "4 séries",
                Repeticoes = "10 a 12 repetições",
                Cuidados = "Use garrafas d'água, mochila com peso ou halteres. Faça movimentos controlados, descendo em 3 segundos e subindo em 1. Essencial para desenvolvimento de glúteos e quadríceps."
            },
            new Treino
            {
                Nome = "Prancha dinâmica",
                Series = "4 séries",
                Repeticoes = "30 segundos",
                Cuidados = "Adicione movimentos como tocar os ombros alternadamente para aumentar a dificuldade. Não force a lombar — mantenha o quadril nivelado. Essencial para estabilidade do core."
            },
            new Treino
            {
                Nome = "Afundo (avanço)",
                Series = "3 séries",
                Repeticoes = "10 repetições por perna",
                Cuidados = "Mantenha o joelho da frente alinhado com o segundo dedo do pé. O joelho de trás deve quase tocar o chão. Alternativas: afundo estacionário ou caminhando. Trabalha glúteo, quadríceps e isquiotibiais."
            },
            new Treino
            {
                Nome = "Remada com mochila",
                Series = "3 séries",
                Repeticoes = "12 repetições por braço",
                Cuidados = "Use uma cadeira ou mesa para apoio. Mochila com livros funciona como haltere. Puxa o cotovelo para cima alinhado ao corpo. Foco em dorsal e bíceps."
            },
            new Treino
            {
                Nome = "Fundos entre cadeiras (tríceps)",
                Series = "3 séries",
                Repeticoes = "10 a 15 repetições",
                Cuidados = "Use duas cadeiras firmes ou uma cadeira e o chão. Mantenha os cotovelos apontados para trás, não para os lados. Desça até os cotovelos formarem 90°. Isola bem o tríceps."
            },
            new Treino
            {
                Nome = "Elevação de panturrilha",
                Series = "4 séries",
                Repeticoes = "20 repetições",
                Cuidados = "Pode ser feito em um degrau para maior amplitude. Suba na ponta dos pés lentamente e desça controlando o movimento. Segure uma parede para equilíbrio se necessário."
            }
        },

            ["Treino em Casa"] = new List<Treino>
        {
            new Treino
            {
                Nome = "Agachamento",
                Series = "3 séries",
                Repeticoes = "12 a 15 repetições",
                Cuidados = "Mantenha os joelhos alinhados com os pés. Imagine sentar em uma cadeira invisível. Pode ser feito com peso (mochila, garrafas) para maior intensidade. Desça até as coxas ficarem paralelas ao chão."
            },
            new Treino
            {
                Nome = "Abdominal completo",
                Series = "3 séries",
                Repeticoes = "15 a 20 repetições",
                Cuidados = "Evite puxar o pescoço com as mãos. Contraia o abdômen antes de subir. Expire ao subir, inspire ao descer. Alterne com abdominal oblíquo (cotovelo em direção ao joelho oposto) para trabalhar todo o core."
            },
            new Treino
            {
                Nome = "Prancha isométrica",
                Series = "3 séries",
                Repeticoes = "20 a 40 segundos",
                Cuidados = "Respeite seu limite e evolua gradualmente. Cotovelos abaixo dos ombros, corpo reto, não eleve o quadril. Respire normalmente durante toda a duração. Essencial para saúde da coluna."
            },
            new Treino
            {
                Nome = "Flexão de braço",
                Series = "3 séries",
                Repeticoes = "8 a 15 repetições",
                Cuidados = "Adapte para seu nível: iniciante com joelhos apoiados, intermediário completo, avançado com pés elevados. Mantenha o cotovelo perto do corpo para maior ativação do tríceps."
            },
            new Treino
            {
                Nome = "Afundo estacionário",
                Series = "3 séries",
                Repeticoes = "10 repetições por perna",
                Cuidados = "Mantenha o tronco ereto e o joelho da frente não ultrapassando demais a ponta do pé. Pode segurar uma parede para equilíbrio. Alterne as pernas a cada série."
            },
            new Treino
            {
                Nome = "Ponte de glúteos",
                Series = "3 séries",
                Repeticoes = "15 repetições",
                Cuidados = "Deite de costas, joelhos dobrados, pés no chão. Eleve o quadril contraindo o glúteo no topo. Segure 2 segundos no pico. Para dificultar, apoie um peso no abdômen ou eleve uma perna."
            },
            new Treino
            {
                Nome = "Polichinelo ou marcha no lugar",
                Series = "3 séries",
                Repeticoes = "30 segundos",
                Cuidados = "Ideal para aquecer ou finalizar o treino. Para quem tem restrições articulares, prefira a marcha elevando bem os joelhos. Mantenha os braços em movimento para maior gasto calórico."
            }
        },

            ["Cardio"] = new List<Treino>
        {
            new Treino
            {
                Nome = "Caminhada progressiva",
                Series = "1 sessão",
                Repeticoes = "20 a 40 minutos",
                Cuidados = "Use calçado confortável com amortecimento. Mantenha postura ereta, braços em movimento. Aumente o pace a cada semana. Excelente para iniciantes e pessoas com restrições articulares."
            },
            new Treino
            {
                Nome = "Corrida leve (trote)",
                Series = "1 sessão",
                Repeticoes = "15 a 20 minutos",
                Cuidados = "Pare imediatamente em caso de tontura, dor no peito ou falta de ar. Comece alternando corrida e caminhada (ex: 1 min correndo, 2 min caminhando). Aqueça por 5 min antes e alongue após."
            },
            new Treino
            {
                Nome = "Bicicleta ergométrica",
                Series = "1 sessão",
                Repeticoes = "20 a 30 minutos",
                Cuidados = "Ajuste o banco para que o joelho fique levemente dobrado no ponto mais baixo da pedalada. Mantenha intensidade moderada (conversação possível). Ótimo para quem tem impacto nos joelhos."
            },
            new Treino
            {
                Nome = "HIIT (treino intervalado)",
                Series = "4 a 6 rodadas",
                Repeticoes = "20s esforço máximo + 40s descanso",
                Cuidados = "Não indicado para iniciantes sem base cardiovascular. Alterne exercícios como burpee, polichinelo e agachamento com salto. Limite a 2 sessões por semana para evitar overtraining."
            },
            new Treino
            {
                Nome = "Pular corda",
                Series = "3 sessões",
                Repeticoes = "1 a 2 minutos por sessão",
                Cuidados = "Pouso sempre na ponta dos pés. Excelente para coordenação e resistência cardiovascular. Evite em caso de problemas nos tornozelos ou joelhos sem avaliação médica prévia."
            },
            new Treino
            {
                Nome = "Dança / Zumba",
                Series = "1 sessão",
                Repeticoes = "20 a 40 minutos",
                Cuidados = "Ótima opção para quem não gosta de treinos tradicionais. Queima entre 300 e 600 kcal por hora. Aulas presenciais ou vídeos online são acessíveis. Foco na diversão e na consistência."
            }
        },

            ["Alongamento"] = new List<Treino>
        {
            new Treino
            {
                Nome = "Alongamento de isquiotibiais",
                Series = "2 séries por lado",
                Repeticoes = "30 segundos cada",
                Cuidados = "Sem movimentos bruscos. Sente no chão com a perna estendida e alcance o pé suavemente. Sinta a tensão na parte posterior da coxa — não force além do limite. Fundamental para prevenir lesões."
            },
            new Treino
            {
                Nome = "Alongamento de quadríceps",
                Series = "2 séries por lado",
                Repeticoes = "30 segundos cada",
                Cuidados = "Em pé, segure o tornozelo e puxe suavemente em direção ao glúteo. Mantenha equilíbrio apoiando em uma parede se necessário. Sinta o alongamento na frente da coxa."
            },
            new Treino
            {
                Nome = "Alongamento de ombros e braços",
                Series = "2 séries por lado",
                Repeticoes = "20 a 30 segundos cada",
                Cuidados = "Não force articulações. Traga o braço cruzado na frente do peito e pressione suavemente com o outro braço. Para o tríceps, leve o cotovelo atrás da cabeça e empurre gentilmente."
            },
            new Treino
            {
                Nome = "Mobilidade cervical",
                Series = "2 séries",
                Repeticoes = "8 movimentos lentos por direção",
                Cuidados = "Movimentos lentos e controlados: inclinação lateral, rotação e flexão. Nunca faça rotações cervicais completas (movimento circular). Ideal para quem passa muito tempo sentado ou no computador."
            },
            new Treino
            {
                Nome = "Alongamento de coluna (gato-vaca)",
                Series = "2 séries",
                Repeticoes = "10 repetições lentas",
                Cuidados = "De quatro apoios, alterne entre arqueamento (gato) e extensão (vaca) da coluna, respirando profundamente. Excelente para mobilidade vertebral e alívio de tensão lombar."
            },
            new Treino
            {
                Nome = "Postura da criança (yoga)",
                Series = "1 série",
                Repeticoes = "40 a 60 segundos",
                Cuidados = "Ajoelhe, sente nos calcanhares e estenda os braços à frente com a testa no chão. Relaxe a lombar e os ombros completamente. Ótima para finalizar o treino e descomprimir a coluna."
            },
            new Treino
            {
                Nome = "Alongamento de panturrilha",
                Series = "2 séries por lado",
                Repeticoes = "30 segundos cada",
                Cuidados = "Apoie as mãos na parede, perna de trás estendida com o calcanhar no chão. Essencial para quem corre, caminha muito ou usa salto. Previne fascite plantar e câimbras."
            }
        },

            ["Funcional"] = new List<Treino>
        {
            new Treino
            {
                Nome = "Agachamento funcional",
                Series = "4 séries",
                Repeticoes = "12 a 15 repetições",
                Cuidados = "Mantenha postura correta com peito aberto e olhar à frente. Trabalha múltiplos grupos musculares simultaneamente. Simula movimentos do cotidiano como sentar e levantar com segurança."
            },
            new Treino
            {
                Nome = "Prancha com toque no ombro",
                Series = "3 séries",
                Repeticoes = "10 toques por lado",
                Cuidados = "Evite sobrecarga lombar mantendo o quadril estável. A cada toque, o corpo deve permanecer o mais imóvel possível. Desenvolve estabilidade e coordenação do core."
            },
            new Treino
            {
                Nome = "Elevação de joelhos em marcha",
                Series = "3 séries",
                Repeticoes = "20 elevações alternadas",
                Cuidados = "Faça no seu ritmo. Eleve o joelho até a altura do quadril. Excelente para ativação do core, coordenação e aquecimento. Pode ser feito com movimentos de braço opostos para maior desafio."
            },
            new Treino
            {
                Nome = "Dead bug (bug morto)",
                Series = "3 séries",
                Repeticoes = "8 repetições por lado",
                Cuidados = "Deite de costas, braços estendidos para cima e joelhos em 90°. Abaixe simultaneamente o braço oposto à perna que estende. Mantenha a lombar pressionada no chão. Excelente para coordenação e core profundo."
            },
            new Treino
            {
                Nome = "Swing com peso (ou garrafa d'água)",
                Series = "3 séries",
                Repeticoes = "12 repetições",
                Cuidados = "Use uma garrafa cheia, mochila ou kettlebell. O movimento é iniciado pelo quadril, não pelos braços. Mantenha a coluna neutra e os joelhos levemente dobrados. Trabalha cadeia posterior e core."
            },
            new Treino
            {
                Nome = "Step up (subida em degrau)",
                Series = "3 séries",
                Repeticoes = "10 repetições por perna",
                Cuidados = "Use um degrau firme ou caixote. Suba com o pé inteiro apoiado, se erga estendendo o joelho completamente. Trabalha glúteo, quadríceps e equilíbrio funcional. Pode adicionar peso progressivamente."
            },
            new Treino
            {
                Nome = "Rotação de tronco com peso",
                Series = "3 séries",
                Repeticoes = "10 rotações por lado",
                Cuidados = "Sentado ou em pé, segure um objeto com peso e gire o tronco de um lado ao outro de forma controlada. Mantém a mobilidade da coluna torácica e ativa o oblíquo. Essencial para movimentos rotacionais do dia a dia."
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