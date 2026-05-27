namespace MauiAppBemEstarDigital.Views;

public partial class DietPage : ContentPage
{
    public class Dieta
    {
        public string Nome { get; set; }
        public string Refeicao { get; set; }
        public string Alimentos { get; set; }
        public string Cuidados { get; set; }
    }

    Dictionary<string, List<Dieta>> dietas;

    public DietPage()
    {
        InitializeComponent();
        dietas = new Dictionary<string, List<Dieta>>
        {
            ["Dieta para emagrecimento"] = new List<Dieta>
        {
            new Dieta
            {
                Nome = "Café da manhã",
                Refeicao = "Refeição: Frutas, aveia e proteína leve",
                Alimentos = "Alimentos sugeridos: banana, maçã, aveia em flocos, iogurte natural desnatado, chia e mel.",
                Cuidados = "Evite restrições exageradas. Inclua fibras para maior saciedade. Mantenha hidratação adequada (200–300 ml de água ao acordar)."
            },
            new Dieta
            {
                Nome = "Lanche da manhã",
                Refeicao = "Refeição: Lanche leve e nutritivo",
                Alimentos = "Castanhas (porção pequena), 1 fruta de baixo índice glicêmico (pera, kiwi ou ameixa) ou 1 iogurte light.",
                Cuidados = "Evite pular este lanche para não chegar com muita fome no almoço. Prefira alimentos naturais a barras industrializadas."
            },
            new Dieta
            {
                Nome = "Almoço",
                Refeicao = "Refeição: Prato equilibrado e colorido",
                Alimentos = "Frango grelhado ou peixe, arroz integral, feijão ou lentilha, salada verde com azeite e limão, legumes no vapor (brócolis, cenoura, abobrinha).",
                Cuidados = "Monte o prato seguindo o método do prato saudável: metade de vegetais, 1/4 de proteína, 1/4 de carboidrato complexo. Mastige devagar e sem distrações."
            },
            new Dieta
            {
                Nome = "Lanche da tarde",
                Refeicao = "Refeição: Energia para o período da tarde",
                Alimentos = "Vitamina de frutas com leite desnatado, 1 tapioca com queijo branco, ou frutas com pasta de amendoim natural (sem açúcar).",
                Cuidados = "Cuidado com sucos industrializados. Prefira frutas inteiras para preservar as fibras e reduzir o índice glicêmico."
            },
            new Dieta
            {
                Nome = "Jantar",
                Refeicao = "Refeição: Jantar leve e saciante",
                Alimentos = "Sopa de legumes com frango desfiado, omelete com espinafre e tomate, ou peixe assado com purê de couve-flor e salada.",
                Cuidados = "Prefira jantares mais leves do que o almoço. Evite carboidratos simples à noite. Jante pelo menos 2h antes de dormir."
            },
            new Dieta
            {
                Nome = "Ceia (opcional)",
                Refeicao = "Refeição: Ceia leve para evitar fome noturna",
                Alimentos = "1 copo de leite morno desnatado, iogurte natural com canela, ou 1 fatia de queijo cottage com torrada integral.",
                Cuidados = "A ceia é indicada apenas se houver fome real. Evite exageros. Alimentos ricos em triptofano (leite, banana) auxiliam no sono."
            }
        },

            ["Dieta para ganho de massa"] = new List<Dieta>
        {
            new Dieta
            {
                Nome = "Café da manhã",
                Refeicao = "Refeição: Café rico em proteínas e energia",
                Alimentos = "3–4 ovos mexidos ou estrelados, 2 fatias de pão integral, 1 banana, 1 copo de leite integral ou shake proteico, pasta de amendoim natural.",
                Cuidados = "O café da manhã deve ser a refeição mais calórica. Considere orientação de nutricionista para calcular a necessidade calórica individual."
            },
            new Dieta
            {
                Nome = "Lanche pré-treino",
                Refeicao = "Refeição: Energia para o treino",
                Alimentos = "Banana com pasta de amendoim, batata-doce cozida com frango, pão integral com atum, ou shake de carboidrato com proteína.",
                Cuidados = "Consuma de 30 a 60 minutos antes do treino. Evite alimentos muito gordurosos ou fibrosos que podem causar desconforto gástrico."
            },
            new Dieta
            {
                Nome = "Almoço",
                Refeicao = "Refeição: Almoço hipercalórico e nutritivo",
                Alimentos = "Frango, carne vermelha magra ou peixe, arroz branco ou batata-doce, feijão, ovo cozido, legumes e azeite de oliva.",
                Cuidados = "Aumente progressivamente a ingestão calórica. Combine proteína de alto valor biológico com carboidratos de absorção moderada."
            },
            new Dieta
            {
                Nome = "Lanche pós-treino",
                Refeicao = "Refeição: Recuperação muscular",
                Alimentos = "Shake de whey protein com leite integral e banana, ou iogurte grego com granola e mel, ou ovos cozidos com arroz.",
                Cuidados = "Consuma até 45 minutos após o treino para otimizar a síntese proteica. Priorize proteínas de rápida absorção nesse momento."
            },
            new Dieta
            {
                Nome = "Jantar",
                Refeicao = "Refeição: Proteína + carboidrato para recuperação noturna",
                Alimentos = "Frango ou carne, batata-doce assada, arroz integral, vegetais refogados no azeite, e salada com azeite e limão.",
                Cuidados = "O jantar deve ser substancioso. A proteína consumida à noite contribui para a síntese muscular durante o sono. Evite excessos de gordura saturada."
            },
            new Dieta
            {
                Nome = "Ceia",
                Refeicao = "Refeição: Nutrição durante o sono",
                Alimentos = "Caseína (proteína de digestão lenta), iogurte grego integral, queijo cottage, ou omelete leve com queijo.",
                Cuidados = "Proteínas de absorção lenta à noite auxiliam na recuperação e crescimento muscular durante o sono. Evite carboidratos simples nesse momento."
            }
        },

            ["Dieta low carb"] = new List<Dieta>
        {
            new Dieta
            {
                Nome = "Café da manhã",
                Refeicao = "Refeição: Café sem carboidratos refinados",
                Alimentos = "Ovos mexidos com espinafre e queijo, abacate fatiado, bacon ou presunto sem aditivos, café com creme de leite ou manteiga ghee.",
                Cuidados = "Eliminação brusca de carboidratos pode causar a 'gripe low carb' nos primeiros dias (fadiga, tontura). Hidrate-se bem e aumente a ingestão de sal."
            },
            new Dieta
            {
                Nome = "Almoço",
                Refeicao = "Refeição: Proteína e gorduras boas",
                Alimentos = "Abacate, ovos, legumes não amiláceos (brócolis, couve-flor, abobrinha), carnes magras e gordurosas, oleaginosas, azeite de oliva extravirgem.",
                Cuidados = "Fique atento ao consumo de vegetais ricos em carboidratos (beterraba, milho, ervilha). Prefira folhas verdes, brócolis, couve-flor e abobrinha."
            },
            new Dieta
            {
                Nome = "Lanche",
                Refeicao = "Refeição: Lanche low carb e saciante",
                Alimentos = "Queijo em cubos, ovos cozidos, castanhas, nozes, azeitonas, atum com maionese caseira, pepino fatiado com pasta de amêndoas.",
                Cuidados = "Lanches ricos em gordura proporcionam maior saciedade. Evite frutas de alto índice glicêmico como manga, uva e melancia neste padrão alimentar."
            },
            new Dieta
            {
                Nome = "Jantar",
                Refeicao = "Refeição: Jantar proteico e verde",
                Alimentos = "Salmão grelhado com brócolis no vapor, bife acebolado com salada de folhas, omelete recheada com queijo e tomate, ou frango assado com couve-flor gratinada.",
                Cuidados = "Mudanças bruscas podem não funcionar para todos. Consulte um profissional de saúde antes de iniciar, especialmente pessoas com diabetes ou doenças renais."
            }
        },

            ["Dieta vegetariana"] = new List<Dieta>
        {
            new Dieta
            {
                Nome = "Café da manhã",
                Refeicao = "Refeição: Café nutritivo sem carne",
                Alimentos = "Iogurte natural com frutas e granola, ovos mexidos com tomate e ervas, pão integral com homus e abacate, ou mingau de aveia com chia e frutas vermelhas.",
                Cuidados = "Garanta proteína suficiente desde o café da manhã. Ovos e laticínios são ótimas fontes para lacto-ovo-vegetarianos. Veganos devem priorizar sementes e leguminosas."
            },
            new Dieta
            {
                Nome = "Almoço",
                Refeicao = "Refeição: Proteínas vegetais completas",
                Alimentos = "Feijão, lentilha, grão-de-bico ou ervilha, tofu grelhado ou tempeh, arroz integral, legumes variados, salada verde com sementes de girassol e azeite.",
                Cuidados = "Combine leguminosas com cereais integrais (ex: arroz com feijão) para obter proteína completa com todos os aminoácidos essenciais."
            },
            new Dieta
            {
                Nome = "Lanche",
                Refeicao = "Refeição: Lanche natural e energético",
                Alimentos = "Mix de castanhas e frutas secas, homus com palitos de cenoura e pepino, frutas com iogurte natural, ou tapioca com queijo e tomate.",
                Cuidados = "Cuidado com deficiências nutricionais típicas da dieta vegetariana: vitamina B12, ferro, zinco e ômega-3. Suplementação pode ser necessária — consulte um nutricionista."
            },
            new Dieta
            {
                Nome = "Jantar",
                Refeicao = "Refeição: Jantar rico e variado",
                Alimentos = "Curry de grão-de-bico com espinafre, sopa de lentilha com legumes, risoto de cogumelos, strogonoff de tofu, ou macarrão integral com molho de tomate e queijo.",
                Cuidados = "Varie as fontes proteicas ao longo da semana. Inclua alimentos fermentados (iogurte, kefir, missô) para saúde intestinal. Observe sinais de carências nutricionais."
            }
        },

            ["Dieta para foco mental"] = new List<Dieta>
        {
            new Dieta
            {
                Nome = "Café da manhã",
                Refeicao = "Refeição: Ativação cognitiva matinal",
                Alimentos = "Ovos (ricos em colina), salmão defumado, abacate, frutas vermelhas (mirtilo, morango), café preto sem açúcar, nozes e amêndoas.",
                Cuidados = "Evite açúcares refinados no café da manhã — causam picos glicêmicos seguidos de queda de energia e concentração. Prefira gorduras boas e proteínas."
            },
            new Dieta
            {
                Nome = "Almoço",
                Refeicao = "Refeição: Nutrição cerebral completa",
                Alimentos = "Salmão ou sardinha (ômega-3), arroz integral, brócolis ou couve (vitaminas do complexo B), nozes, sementes de abóbora e azeite extravirgem.",
                Cuidados = "Refeições muito pesadas causam sonolência pós-almoço e reduzem o foco. Prefira porções moderadas com alta densidade nutricional."
            },
            new Dieta
            {
                Nome = "Lanche",
                Refeicao = "Refeição: Energia sustentada para o cérebro",
                Alimentos = "Mix de oleaginosas (castanha-do-pará, nozes, amêndoas), frutas de baixo IG (maçã, pera), chocolate amargo acima de 70%, chá verde ou matcha.",
                Cuidados = "Sono e hidratação adequados influenciam diretamente a concentração — nenhuma dieta substitui uma boa noite de sono. Consuma ao menos 2L de água por dia."
            },
            new Dieta
            {
                Nome = "Jantar",
                Refeicao = "Refeição: Recuperação e preparação para o sono",
                Alimentos = "Frango ou peixe com legumes, abacate, alimentos ricos em magnésio (espinafre, amêndoas, banana), chá de camomila ou melissa.",
                Cuidados = "O sono é essencial para a consolidação da memória. Evite cafeína após as 15h. Alimentos ricos em triptofano (leite, banana, ovos) auxiliam na qualidade do sono."
            },
            new Dieta
            {
                Nome = "Hidratação",
                Refeicao = "Hidratação: Essencial para função cognitiva",
                Alimentos = "Água, chá verde, chá de ervas (sem açúcar), água com limão e hortelã, água de coco natural (com moderação).",
                Cuidados = "Desidratação leve (1–2% do peso corporal) já compromete memória, atenção e tempo de reação. Distribua o consumo de água ao longo do dia — não espere sentir sede."
            }
        }
        };
    }

    private void pickerDietas_SelectedIndexChanged(object sender, EventArgs e)
    {
        string dietaSelecionada =
            pickerDietas.SelectedItem?.ToString();

        if (!string.IsNullOrEmpty(dietaSelecionada)
            && dietas.ContainsKey(dietaSelecionada))
        {
            collectionDietas.ItemsSource =
                dietas[dietaSelecionada];
        }
    }

    private void Voltar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Views.HomePage());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

}