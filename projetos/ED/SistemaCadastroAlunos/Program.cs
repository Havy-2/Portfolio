using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> alunos = new List<string>();

        Console.WriteLine("=== SISTEMA DE CADASTRO DE ALUNOS ===\n");

        // 3. Cadastrar 10 alunos
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o nome do {i + 1}º aluno: ");
            string nome = Console.ReadLine();

            alunos.Add(nome);
        }

        // 4. Exibir todos os alunos
        Console.WriteLine("\n=== LISTA DE ALUNOS ===");

        for (int i = 0; i < alunos.Count; i++)
        {
            Console.WriteLine($"{i} - {alunos[i]}");
        }

        // 5. Mostrar a quantidade de alunos
        Console.WriteLine($"\nTotal de alunos: {alunos.Count}");

        // 6. Alterar o nome de um aluno
        Console.Write("\nDigite o índice do aluno que deseja alterar: ");
        int indice = int.Parse(Console.ReadLine());

        Console.Write("Digite o novo nome: ");
        string novoNome = Console.ReadLine();

        alunos[indice] = novoNome;

        // 7. Remover um aluno
        Console.Write("\nDigite o índice do aluno que deseja remover: ");
        int indiceRemover = int.Parse(Console.ReadLine());

        alunos.RemoveAt(indiceRemover);

        // 8. Exibir a lista final
        Console.WriteLine("\n=== LISTA FINAL ===");

        for (int i = 0; i < alunos.Count; i++)
        {
            Console.WriteLine($"{i} - {alunos[i]}");
        }

        Console.WriteLine($"\nTotal de alunos: {alunos.Count}");
    }
}
