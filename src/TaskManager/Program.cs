using System;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var taskService = new TaskService();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("GERENCIADOR DE TAREFAS");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1. Adicionar tarefa");
                Console.WriteLine("2. Excluir tarefa");
                Console.WriteLine("3. Editar tarefa");
                Console.WriteLine("4. Listar tarefas");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                char opcao = Console.ReadKey().KeyChar;

                Console.WriteLine("\n");

                switch (opcao)
                {
                    case '1':
                        Console.Write("Informe a descrição da tarefa: ");
                        string descricao = Console.ReadLine();
                        taskService.AdicionarTarefa(descricao);
                        break;

                    case '2':
                        Console.Write("Informe o ID da tarefa a excluir: ");
                        int excluirId = int.Parse(Console.ReadLine());
                        taskService.ExcluirTarefa(excluirId);
                        break;

                    case '3':
                        Console.Write("Informe o ID da tarefa a editar: ");
                        int editarId = int.Parse(Console.ReadLine());
                        Console.Write("Informe a nova descrição: ");
                        string novaDescricao = Console.ReadLine();
                        taskService.EditarTarefa(editarId, novaDescricao);
                        break;

                    case '4':
                        var tarefas = taskService.ListarTarefas();
                        Console.WriteLine("TAREFAS:");
                        foreach (var tarefa in tarefas)
                        {
                            Console.WriteLine($"ID: {tarefa.Id} | Descrição: {tarefa.Descricao}");
                        }
                        break;

                    case '5':
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Programa encerrado.");
        }
    }
}