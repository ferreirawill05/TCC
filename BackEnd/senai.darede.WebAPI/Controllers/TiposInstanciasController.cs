using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.darede.WebAPI.Domains;
using senai.darede.WebAPI.Interfaces;
using senai.darede.WebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.darede.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TiposInstanciasController : ControllerBase
    {
        private ITipoInstanciumRepository _TipoInstanciumRepository { get; set; }

        public TiposInstanciasController()
        {
            _TipoInstanciumRepository = new TipoInstanciumRepository();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            TipoInstancium tipoInstanciaBuscado = _TipoInstanciumRepository.ListarId(id);

            if (tipoInstanciaBuscado == null)
            {
                return NotFound("Nenhuma Tipo Instancia encontrado.");
            }

            return Ok(tipoInstanciaBuscado);
        }

        [HttpPost]
        public IActionResult Post(TipoInstancium novoTipoInstancia)
        {
            _TipoInstanciumRepository.Cadastrar(novoTipoInstancia);

            return StatusCode(201);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _TipoInstanciumRepository.Deletar(id);
            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TipoInstancium tipoInstanciaAtualizado)
        {
            TipoInstancium tipoInstanciaBuscado = _TipoInstanciumRepository.ListarId(id);

            if (tipoInstanciaBuscado == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Tipo Instância não encontrado.",
                        erro = true
                    });
            }

            try
            {
                _TipoInstanciumRepository.Atualizar(id, tipoInstanciaAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
