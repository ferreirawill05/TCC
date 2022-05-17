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
    
    public class SoftwaresController : ControllerBase
    {
        private ISoftwareRepository _SoftwareRepository { get; set; }

        public SoftwaresController()
        {
            _SoftwareRepository = new SoftwareRepository();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Software softwareBuscado = _SoftwareRepository.ListarId(id);

            if (softwareBuscado == null)
            {
                return NotFound("Nenhuma Software encontrado.");
            }

            return Ok(softwareBuscado);
        }

        [HttpPost]
        public IActionResult Post(Software novoSoftware)
        {
            _SoftwareRepository.Cadastrar(novoSoftware);

            return StatusCode(201);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _SoftwareRepository.Deletar(id);
            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Software softwareAtualizado)
        {
            Software softwareBuscado = _SoftwareRepository.ListarId(id);

            if (softwareBuscado == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Software não encontrado.",
                        erro = true
                    });
            }

            try
            {
                _SoftwareRepository.Atualizar(id, softwareAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
