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
    public class ArmsInstanciasController : ControllerBase
    {
        private IArmInstanciumRepository _ArmInstanciumRepository { get; set; }

        public ArmsInstanciasController()
        {
            _ArmInstanciumRepository = new ArmInstanciumRepository();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            ArmInstancium armInstanciaBuscado = _ArmInstanciumRepository.ListarId(id);

            if (armInstanciaBuscado == null)
            {
                return NotFound("Nenhuma Armazenamento de Instancia encontrado.");
            }

            return Ok(armInstanciaBuscado);
        }

        [HttpPost]
        public IActionResult Post(ArmInstancium novoArmInstancia)
        {
            _ArmInstanciumRepository.Cadastrar(novoArmInstancia);

            return StatusCode(201);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _ArmInstanciumRepository.Deletar(id);
            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, ArmInstancium armInstanciaAtualizado)
        {
            ArmInstancium armInstanciaBuscado = _ArmInstanciumRepository.ListarId(id);

            if (armInstanciaBuscado == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Armazenamento de Instância não encontrado.",
                        erro = true
                    });
            }

            try
            {
                _ArmInstanciumRepository.Atualizar(id, armInstanciaAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
