using TaskModel = TaskManager.Models.Task;
using System.Collections.Generic;
using TaskManager.Models;


namespace TaskManager.Services
{
    public class TaskService
    {
        private List<TaskModel> tarefas = new List<TaskModel>();
        private int proximoId = 1;

        public void AdicionarTarefa(string descricao)
        {
            tarefas.Add(new TaskModel { Id = proximoId++, Descricao = descricao });
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

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

        public List<TaskModel> ListarTarefas()
        {
            return tarefas;
        }
    }
}