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
    public class ZonasController : ControllerBase
    {
        private IZonaRepository _ZonaRepository { get; set; }

        public ZonasController()
        {
            _ZonaRepository = new ZonaRepository();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Zona zonaBuscada = _ZonaRepository.ListarId(id);

            if (zonaBuscada == null)
            {
                return NotFound("Nenhuma Zona encontrada.");
            }

            return Ok(zonaBuscada);
        }

        [HttpPost]
        public IActionResult Post(Zona novaZona)
        {
            _ZonaRepository.Cadastrar(novaZona);

            return StatusCode(201);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _ZonaRepository.Deletar(id);
            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Zona zonaAtualizada)
        {
            Zona zonaBuscada = _ZonaRepository.ListarId(id);

            if (zonaBuscada == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Zona não encontrado.",
                        erro = true
                    });
            }

            try
            {
                _ZonaRepository.Atualizar(id, zonaAtualizada);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
