using TarefaApi.Models;

namespace TarefaApi.Repositores
{
    public interface ITarefasRepositories
    {
        IEnumerable<Tarefa> ListarTarefas();
        Tarefa GetTarefaId(int codigo);
        void AdicionarTarefas(Tarefa tarefa);
        void AlterarTarefas(Tarefa tarefa);
        
    }
}
