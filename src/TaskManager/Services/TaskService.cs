using TaskModel = TaskManager.Models.Task;
using System.Collections.Generic;
using TaskManager.Models;

namespace TaskManager.Services
{
    public class TaskService
    {
        // Lista de tarefas e ID para a próxima tarefa
        private List<TaskModel> tarefas = new List<TaskModel>();
        private int proximoId = 1;

        // Adiciona uma nova tarefa
        public void AdicionarTarefa(string descricao)
        {
            tarefas.Add(new TaskModel { Id = proximoId++, Descricao = descricao });
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        // Exclui uma tarefa pelo ID
        public void ExcluirTarefa(int id)
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine("Tarefa excluída com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        // Edita a descrição de uma tarefa
        public void EditarTarefa(int id, string novaDescricao)
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefa.Descricao = novaDescricao;
                Console.WriteLine("Tarefa editada com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        // Retorna a lista de todas as tarefas
        public List<TaskModel> ListarTarefas()
        {
            return tarefas;
        }
    }
}