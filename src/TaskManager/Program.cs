using System;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerenciador de Tarefas");
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Sair");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.WriteLine("Digite a tarefa:");
                string tarefa = Console.ReadLine();
                Console.WriteLine("Tarefa adicionada: " + tarefa);
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Saindo...");
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}
