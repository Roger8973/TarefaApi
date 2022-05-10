using TarefaApi.Models;

namespace TarefaApi.Repositores
{
    public class TarefasRepositories : ITarefasRepositories
    {
        public readonly List<Tarefa> _tarefas;

        public TarefasRepositories()
        {
            _tarefas = new List<Tarefa>();
        }

        public void AdicionarTarefas(Tarefa tarefa)
        {
            _tarefas.Add(tarefa);
        }

        public void AlterarTarefas(Tarefa tarefa)
        {
            var index = _tarefas.FindIndex(0, 1, x => x.Codigo == tarefa.Codigo);
            _tarefas[index] = tarefa;
        }



        public Tarefa GetTarefa(int codigo)
        {
           return _tarefas[codigo];
        }

        public IEnumerable<Tarefa> ListarTarefas()
        {
            return _tarefas;
        }
      
    }
}
