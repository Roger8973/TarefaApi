using TarefaApi.Models.Enums;

namespace TarefaApi.Models
{
    public class Tarefa
    {
      

        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public StatusTarefa Status { get; set; }

        public Tarefa(int codigo, string descricao, StatusTarefa status)
        {
            Codigo = codigo;
            Descricao = descricao;
            Status = status;
        }
        public Tarefa()
        {

        }
    }
}  

