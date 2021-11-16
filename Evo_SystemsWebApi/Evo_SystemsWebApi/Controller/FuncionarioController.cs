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
    public class FuncionarioController : ControllerBase
    {

        private IfuncionarioRepository _funcionarioRepository { get; set; }


        /// <summary>
        /// Lista todos os funcionario
        /// </summary>
        /// <returns>Uma lista de funcionario e um status code 200 - ok </returns>
        [HttpGet]
        public IActionResult Get()
        {
            //retorna a resposta da  requisição fazendo uma chamada para o método
            return Ok(_funcionarioRepository.Listar());
        }

        /// <summary>
        /// Cadastra um novo Funcionario
        /// </summary>
        /// <param name="NovoFuncionario">objeto NovoFuncionario que será cadastrado</param>
        /// <returns>um statud code 201- Created</returns>
        [HttpPost]
        public IActionResult Post(Funcionario NovoFuncionario)

        {
            //faza a chamada para o método 
            _funcionarioRepository.Cadastrar(NovoFuncionario);

            return StatusCode(201);
        }



        [HttpPut("{id}")]
        public IActionResult Put(int id, Funcionario funcionarioAtualizado)
        {
            try
            {
                _funcionarioRepository.Atualizar(id, funcionarioAtualizado);

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
            _funcionarioRepository.Deletar(id);

            //retorna um status code
            return StatusCode(204);

        }
    }
}
