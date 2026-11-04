using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();
        int opcao;

        do
        {
            Console.WriteLine("==== SISTEMA DE FILA DE ATENDIMENTO ====");
            Console.WriteLine("1 - Adicionar pessoa");
            Console.WriteLine("2 - Exibir fila");
            Console.WriteLine("3 - Consultar próximo");
            Console.WriteLine("4 - Atender pessoa");
            Console.WriteLine("5 - Exibir quantidade");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            // Tratamento básico para entrada inválida
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida! Digite um número.");
                opcao = -1; // força continuar o laço
                Console.WriteLine();
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome da pessoa: ");
                    string nome = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nome))
                    {
                        fila.Enqueue(nome.Trim());
                        Console.WriteLine("Pessoa adicionada à fila!");
                    }
                    else
                    {
                        Console.WriteLine("Nome inválido. Pessoa não adicionada.");
                    }
                    break;

                case 2:
                    if (fila.Count == 0)
                    {
                        Console.WriteLine("A fila está vazia.");
                    }
                    else
                    {
                        Console.WriteLine("Pessoas na fila:");
                        foreach (string pessoa in fila)
                        {
                            Console.WriteLine(pessoa);
                        }
                    }
                    break;

                case 3:
                    if (fila.Count == 0)
                    {
                        Console.WriteLine("A fila está vazia.");
                    }
                    else
                    {
                        Console.WriteLine("Próxima pessoa: " + fila.Peek());
                    }
                    break;

                case 4:
                    if (fila.Count == 0)
                    {
                        Console.WriteLine("Não há pessoas para atender.");
                    }
                    else
                    {
                        string atendida = fila.Dequeue();
                        Console.WriteLine("Pessoa atendida: " + atendida);
                    }
                    break;

                case 5:
                    Console.WriteLine("Quantidade de pessoas na fila: " + fila.Count);
                    break;

                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine();
        } while (opcao != 0);
    }
}