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
            var index = _tarefas.FindIndex(x => x.Codigo == tarefa.Codigo);
            _tarefas[index] = tarefa;
        }

        public Tarefa GetTarefaId(int codigo)
        {
           return _tarefas.FirstOrDefault(x => x.Codigo == codigo);
        }

        public IEnumerable<Tarefa> ListarTarefas()
        {
            return _tarefas;
        }
      
    }
}
