using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Cria uma lista vazia de tarefas
        List<string> tarefas = new List<string>();

        // 2. Permite ao usuário cadastrar 5 tarefas
        Console.Write("Digite uma tarefa: ");
        tarefas.Add(Console.ReadLine());

        Console.Write("Digite uma tarefa: ");
        tarefas.Add(Console.ReadLine());

        Console.Write("Digite uma tarefa: ");
        tarefas.Add(Console.ReadLine());

        Console.Write("Digite uma tarefa: ");
        tarefas.Add(Console.ReadLine());

        Console.Write("Digite uma tarefa: ");
        tarefas.Add(Console.ReadLine());

        Console.WriteLine();

        // 3. Exibe todas as tarefas
        Console.WriteLine("=== SUAS TAREFAS ===");
        Console.WriteLine("1 - " + tarefas[0]);
        Console.WriteLine("2 - " + tarefas[1]);
        Console.WriteLine("3 - " + tarefas[2]);
        Console.WriteLine("4 - " + tarefas[3]);
        Console.WriteLine("5 - " + tarefas[4]);

        // 4. Mostra o total de tarefas cadastradas
        Console.WriteLine();
        Console.WriteLine("Total de tarefas cadastradas: " + tarefas.Count);
        Console.WriteLine();

        // 5. Pergunta qual tarefa deseja remover
        Console.Write("Qual tarefa deseja remover? ");
        string tarefaRemover = Console.ReadLine();

        // 6. Remove a tarefa da lista
        tarefas.Remove(tarefaRemover);

        Console.WriteLine();

        // 7. Exibe a lista atualizada
        Console.WriteLine("=== LISTA ATUALIZADA ===");
        int numero = 1;
        foreach (string tarefa in tarefas)
        {
            Console.WriteLine(numero + " - " + tarefa);
            numero++;
        }

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}