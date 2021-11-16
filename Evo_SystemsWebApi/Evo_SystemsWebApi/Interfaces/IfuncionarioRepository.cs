using Evo_SystemsWebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evo_SystemsWebApi.Interfaces
{
    public interface IfuncionarioRepository
    {

        /// <summary>
        /// Lista todos os Funcionario
        /// </summary>
        /// <returns>Uma lista de Funcionario</returns>
        List<Funcionario> Listar();

        /// <summary>
        /// Busca um Funcionario através do ID
        /// </summary>
        /// <param name="id">ID do Funcionario que será buscado</param>
        /// <returns>Um Funcionario buscado</returns>
        Funcionario BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo Funcionario
        /// </summary>
        /// <param name="novoFuncionario">Objeto novoFuncionario que será cadastrado</param>
        void Cadastrar(Funcionario novoFuncionario);

        /// <summary>
        /// Atualiza um Funcionario existente
        /// </summary>
        /// <param name="id">id do Funcionario que será atualizado</param>
        /// <param name="FuncionarioAtualizado">Objeto Funcionario atualizado com as novas Informações</param>
        void Atualizar(int id, Funcionario FuncionarioAtualizado);

        /// <summary>
        /// Deleta um Funcionario existente
        /// </summary>
        /// <param name="id">ID do Funcionario que será deletado</param>
        void Deletar(int id);


    }
}
