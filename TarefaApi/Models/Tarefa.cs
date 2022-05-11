using TarefaApi.Models.Enums;

namespace TarefaApi.Models
{
    public class Tarefa
    {
        public int Codigo { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }

    }
}

