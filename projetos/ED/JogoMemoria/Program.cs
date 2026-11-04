using System;

class Program
{
    static void Main()
    {
        // ==========================================
        // TABULEIRO DO JOGO (matriz 6x3 = 18 cartas / 9 pares)
        // PERSONALIZAÇÃO 1: letras das cartas alteradas
        // ==========================================
        char[,] tabuleiro =
        {
            { 'X', 'Y', 'Z' },
            { 'K', 'L', 'M' },
            { 'N', 'O', 'P' },
            { 'X', 'Y', 'Z' },
            { 'K', 'L', 'M' },
            { 'N', 'O', 'P' }
        };

        // Controla quais cartas já foram encontradas
        bool[,] encontrada = new bool[6, 3];

        // Controla quais cartas estão temporariamente visíveis
        bool[,] visivel = new bool[6, 3];

        int paresEncontrados = 0;
        int tentativas = 0;
        int pontuacao = 0;   // PERSONALIZAÇÃO 2: contador de pontuação
        int erros = 0;       // PERSONALIZAÇÃO 3: quantidade de erros

        const int LIMITE_TENTATIVAS = 30; // PERSONALIZAÇÃO extra: limite de tentativas

        // INÍCIO DO JOGO
        Console.Clear();
        Console.WriteLine("======================================");
        Console.WriteLine("     CEET - JOGO DA MEMÓRIA PLUS");
        Console.WriteLine("======================================");
        Console.WriteLine();
        Console.WriteLine("Memorize as posições das cartas!");
        Console.WriteLine("Tabuleiro: 6 linhas x 3 colunas | 9 pares");
        Console.WriteLine("Cada par correto vale +10 pontos. Erro: -2 pontos.");
        Console.WriteLine($"Limite de tentativas: {LIMITE_TENTATIVAS}");
        Console.WriteLine();
        ExibirTabuleiroCompleto(tabuleiro);
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para começar...");
        Console.ReadLine();

        // LOOP PRINCIPAL
        while (paresEncontrados < 9 && tentativas < LIMITE_TENTATIVAS)
        {
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("     CEET - JOGO DA MEMÓRIA PLUS");
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.WriteLine($"Pares encontrados: {paresEncontrados}/9");
            Console.WriteLine($"Tentativas: {tentativas}/{LIMITE_TENTATIVAS}");
            Console.WriteLine($"Pontuação: {pontuacao}");
            Console.WriteLine($"Erros: {erros}");
            Console.WriteLine();

            ExibirTabuleiro(tabuleiro, visivel, encontrada);
            Console.WriteLine();

            // PRIMEIRA CARTA
            Console.WriteLine("----- PRIMEIRA CARTA -----");
            int linha1 = LerLinha();
            int coluna1 = LerColuna();

            // Verificar se a carta já foi encontrada
            if (encontrada[linha1, coluna1])
            {
                Console.WriteLine();
                Console.WriteLine("Essa carta já foi encontrada!");
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                continue;
            }

            // Mostrar primeira carta
            visivel[linha1, coluna1] = true;

            Console.Clear();
            ExibirTabuleiro(tabuleiro, visivel, encontrada);

            // SEGUNDA CARTA
            Console.WriteLine("----- SEGUNDA CARTA -----");
            int linha2 = LerLinha();
            int coluna2 = LerColuna();

            // Verificar se é a mesma carta
            if (linha1 == linha2 && coluna1 == coluna2)
            {
                Console.WriteLine();
                Console.WriteLine("Você não pode escolher a mesma carta!");
                visivel[linha1, coluna1] = false;
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                continue;
            }

            // Verificar se a segunda carta já foi encontrada
            if (encontrada[linha2, coluna2])
            {
                Console.WriteLine();
                Console.WriteLine("Essa carta já foi encontrada!");
                visivel[linha1, coluna1] = false;
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                continue;
            }

            // Mostrar segunda carta
            visivel[linha2, coluna2] = true;
            tentativas++;

            Console.Clear();
            ExibirTabuleiro(tabuleiro, visivel, encontrada);
            Console.WriteLine();

            // VERIFICAR SE É UM PAR
            if (tabuleiro[linha1, coluna1] == tabuleiro[linha2, coluna2])
            {
                // PERSONALIZAÇÃO 4: mensagem especial ao encontrar um par
                Console.WriteLine($"*** PAR ENCONTRADO! Carta [{tabuleiro[linha1, coluna1]}] ***");
                Console.WriteLine("Muito bem! +10 pontos.");
                encontrada[linha1, coluna1] = true;
                encontrada[linha2, coluna2] = true;
                paresEncontrados++;
                pontuacao += 10;
            }
            else
            {
                Console.WriteLine("NÃO É UM PAR. As cartas serão escondidas novamente.");
                Console.WriteLine("-2 pontos.");
                visivel[linha1, coluna1] = false;
                visivel[linha2, coluna2] = false;
                erros++;
                pontuacao -= 2;
                if (pontuacao < 0)
                    pontuacao = 0;
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }

        // ENCERRAMENTO
        Console.Clear();
        Console.WriteLine("======================================");
        Console.WriteLine("     CEET - JOGO DA MEMÓRIA PLUS");
        Console.WriteLine("======================================");
        Console.WriteLine();
        ExibirTabuleiroCompleto(tabuleiro);
        Console.WriteLine();

        if (paresEncontrados == 9)
        {
            Console.WriteLine("PARABÉNS! Você encontrou todos os 9 pares!");
        }
        else
        {
            Console.WriteLine("Fim de jogo: o limite de tentativas foi atingido.");
            Console.WriteLine($"Pares encontrados: {paresEncontrados}/9");
        }

        Console.WriteLine();
        Console.WriteLine($"Tentativas: {tentativas}");
        Console.WriteLine($"Erros: {erros}");
        Console.WriteLine($"Pontuação final: {pontuacao}");
        Console.WriteLine();

        // PERSONALIZAÇÃO 5: mensagem de desempenho
        string desempenho;
        if (paresEncontrados == 9 && erros <= 3)
            desempenho = "Desempenho: EXCELENTE! Memória afiada.";
        else if (paresEncontrados == 9 && erros <= 8)
            desempenho = "Desempenho: BOM! Você concluiu com poucos erros.";
        else if (paresEncontrados == 9)
            desempenho = "Desempenho: REGULAR. Concluiu, mas com muitos erros.";
        else
            desempenho = "Desempenho: PRECISA TREINAR. Tente novamente.";

        Console.WriteLine(desempenho);
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para sair...");
        Console.ReadLine();
    }

    // ==========================================
    // MÉTODO PARA LER A LINHA
    // ==========================================
    static int LerLinha()
    {
        while (true)
        {
            Console.Write("Digite a linha (0 a 5): ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int linha))
            {
                if (linha >= 0 && linha <= 5)
                {
                    return linha;
                }
            }
            Console.WriteLine("Linha inválida!");
        }
    }

    // ==========================================
    // MÉTODO PARA LER A COLUNA
    // ==========================================
    static int LerColuna()
    {
        while (true)
        {
            Console.Write("Digite a coluna (0 a 2): ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int coluna))
            {
                if (coluna >= 0 && coluna <= 2)
                {
                    return coluna;
                }
            }
            Console.WriteLine("Coluna inválida!");
        }
    }

    // ==========================================
    // MÉTODO PARA EXIBIR O TABULEIRO (PERSONALIZADO)
    // ==========================================
    static void ExibirTabuleiro(char[,] tabuleiro, bool[,] visivel, bool[,] encontrada)
    {
        Console.WriteLine("     0     1     2");
        Console.WriteLine("  +-----+-----+-----+");

        for (int linha = 0; linha < 6; linha++)
        {
            Console.Write($"{linha} |");
            for (int coluna = 0; coluna < 3; coluna++)
            {
                if (visivel[linha, coluna] || encontrada[linha, coluna])
                {
                    Console.Write($"  {tabuleiro[linha, coluna]}  |");
                }
                else
                {
                    Console.Write("  ?  |");
                }
            }
            Console.WriteLine();
            Console.WriteLine("  +-----+-----+-----+");
        }
        Console.WriteLine();
    }

    // ==========================================
    // MÉTODO PARA MOSTRAR TODAS AS CARTAS
    // ==========================================
    static void ExibirTabuleiroCompleto(char[,] tabuleiro)
    {
        Console.WriteLine("     0     1     2");
        Console.WriteLine("  +-----+-----+-----+");

        for (int linha = 0; linha < 6; linha++)
        {
            Console.Write($"{linha} |");
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write($"  {tabuleiro[linha, coluna]}  |");
            }
            Console.WriteLine();
            Console.WriteLine("  +-----+-----+-----+");
        }
    }
}
