using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TarefaApi.Models;
using TarefaApi.Models.Enums;
using TarefaApi.Repositores;

namespace TarefaApi.Controllers
{
    //[Route("api/")]
    //[ApiController]
    public class TarefasController : Controller
    {
        private readonly ITarefasRepositories _repositorio;

        public TarefasController(ITarefasRepositories repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet("v1/listar")]
        public IActionResult ListarTarefas()
        {

            return Ok(_repositorio.ListarTarefas());
        }

        [HttpGet("v1/listar/{codigo}")]

        public IActionResult ListarTarefas(int codigo)
        {
        
            return Ok(_repositorio.GetTarefa(codigo));
        }

        [HttpPost("v1/adicionar")]

        public IActionResult AdicionarTarefas(Tarefa tarefa)
        {
            foreach (var item in _repositorio.ListarTarefas())
            {
                if (item.Codigo == tarefa.Codigo)
                {
                    return BadRequest("Código duplicado! Tente outro código.");
                }
            }
            if (((int)tarefa.Status) == 1)
            {
                if (tarefa.Descricao != null)
                {
                    _repositorio.AdicionarTarefas(tarefa);
                }
                else
                {
                    return BadRequest("Para adicionar a tarefa, deverá ser adicionada uma descrição.");
                }
            }
            else
            {
                return BadRequest("Para adicionar a tarefa, deverá estar com status 1 - (Pendente).");
            }
            return Ok();
        }

        [HttpPut("v1/alterar")]
        public IActionResult AlterarTarefas(Tarefa tarefa)
        {
            foreach (var item in _repositorio.ListarTarefas())
            {
                if (item.Codigo != tarefa.Codigo)
                {
                    return BadRequest("Para atualizar a tarefa, o código não pode ser alterado.");
                }
            }
            if (tarefa.Descricao != null)
            {
                if ((int)tarefa.Status != 1)
                {
                    _repositorio.AlterarTarefas(tarefa);
                }
                else
                {
                    return BadRequest("Para atualizar a tarefa, o status deverá ser 2 - (Completo)");
                }
            }
            else
            {
                return BadRequest("Para atualizar a tarefa, deverá ser adicionada uma descrição.");
            }




            return Ok();
        }
    }
}
