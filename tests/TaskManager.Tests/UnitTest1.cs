using Xunit;
using TaskManager.Services;

namespace TaskManager.Tests
{
    public class TaskServiceTests
    {
        private TaskService _taskService;

        public TaskServiceTests()
        {
            _taskService = new TaskService();
        }

        [Fact]
        public void AdicionarTarefa_DeveAdicionarTarefaComDescricaoCorreta()
        {
            _taskService.AdicionarTarefa("Teste");

            var tarefas = _taskService.ListarTarefas();
            Assert.Single(tarefas);
            Assert.Equal("Teste", tarefas[0].Descricao);
        }

    }
}
