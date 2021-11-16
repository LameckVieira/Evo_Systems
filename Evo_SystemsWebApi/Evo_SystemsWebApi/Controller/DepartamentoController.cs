using Evo_SystemsWebApi.Domains;
using Evo_SystemsWebApi.Interfaces;
using Evo_SystemsWebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evo_SystemsWebApi.Controller
{
    [Route("v1/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {

        private IdepartamentoRepository _departamentoRepository { get; set; }


        /// <summary>
        /// Lista todos os Departamentos
        /// </summary>
        /// <returns>Uma lista de Departamento e um status code 200 - ok </returns>
        [HttpGet]
        public IActionResult Get()
        {
            //retorna a resposta da  requisição fazendo uma chamada para o método
            return Ok(_departamentoRepository.Listar());
        }

        /// <summary>
        /// Cadastra um novo Departamento
        /// </summary>
        /// <param name="novoDepartamento">objeto novoDepartamento que será cadastrado</param>
        /// <returns>um statud code 201- Created</returns>
        [HttpPost]
        public IActionResult Post(Departamento novoDepartamento)

        {
            //faza a chamada para o método 
            _departamentoRepository.Cadastrar(novoDepartamento);

            return StatusCode(201);
        }


      
        [HttpPut("{id}")]
        public IActionResult Put(int id, Departamento departamentoAtualizado)
        {
            try
            {
                _departamentoRepository.Atualizar(id, departamentoAtualizado);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //faz a chamada para o método
            _departamentoRepository.Deletar(id);

            //retorna um status code
            return StatusCode(204);

        }

    }
}
