using CidadeAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace CidadeAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("/api/[controller]")]
    public class CidadesController : ControllerBase
    {
        private readonly ILogger<CidadesController> _logger;
        private readonly ICidadeRepository _cidadeRepository;
        

        public CidadesController(ICidadeRepository cidadeRepository, ILogger<CidadesController> logger)
        {
            _cidadeRepository = cidadeRepository;
            _logger = logger;
        }


        [HttpGet]
        public JsonResult ListarCidades()
        {
            return new JsonResult(_cidadeRepository.Listar());
        }

        [HttpGet("{id}")]
        public ActionResult<Cidade> ObterCidade(int id)
        {
            Cidade cidade = _cidadeRepository.ObterPorId(id);

            if (cidade == null)
            {
                _logger.LogInformation($"Cidade não encontrada [{id}]");
                return NotFound();
            }

            return Ok(cidade);
        }

        [HttpPost]
        public ActionResult<Cidade> Cadastrar(Cidade cidade)
        {
            _cidadeRepository.Cadastrar(cidade);

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<Cidade> Atualizar(int id, Cidade cidade) {
            Cidade cidadeExistente = _cidadeRepository.ObterPorId(id);

            if (cidadeExistente == null)
            {
                return NotFound();
            }

            cidade.Id = id;

            _cidadeRepository.Atualizar(cidade);

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Cidade> Remover(int id)
        {
            Cidade cidade = _cidadeRepository.ObterPorId(id);

            if (cidade == null)
            {
                return NotFound();
            }

            _cidadeRepository.Remover(cidade);

            return NoContent();
        }
    }
}
