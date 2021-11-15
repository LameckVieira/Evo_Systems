using Evo_SystemsWebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evo_SystemsWebApi.Interfaces
{
    interface IdepartamentoRepository
    {

        /// <summary>
        /// Lista todos os Departamento
        /// </summary>
        /// <returns>Uma lista de Departamento</returns>
        List<Departamento> Listar();

        /// <summary>
        /// Busca um Departamento através do ID
        /// </summary>
        /// <param name="id">ID do Departamento que será buscado</param>
        /// <returns>Um Departamento buscado</returns>
        Departamento BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo Departamento
        /// </summary>
        /// <param name="novoDepartamento">Objeto novo Departamento que será cadastrado</param>
        void Cadastrar(Departamento novoDepartamento);

        /// <summary>
        /// Atualiza um departamento existente
        /// </summary>
        /// <param name="id">id do Funcionario que será atualizado</param>
        /// <param name="departamentoAtualizado">Objeto departamento atualizado com as novas Informações</param>
        void Atualizar(int id, Departamento departamentoAtualizado);

        /// <summary>
        /// Deleta um Departamento existente
        /// </summary>
        /// <param name="id">ID do Departamento que será deletado</param>
        void Deletar(int id);

    }
}
