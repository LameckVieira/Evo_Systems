using Evo_SystemsWebApi.Context;
using Evo_SystemsWebApi.Domains;
using Evo_SystemsWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evo_SystemsWebApi.Repositories
{
    public class funcionarioRepository : IfuncionarioRepository
    {
        private readonly Evo_SystemsContext ctx;
        public funcionarioRepository(Evo_SystemsContext _ctx)
        {
            ctx = _ctx;
        }


        public void Atualizar(int id, Funcionario funcionarioAtualizado)
        {
            Funcionario funcionarioBuscado = ctx.Funcionarios.Find(id);

            if (funcionarioAtualizado != null)
            {
                funcionarioAtualizado.Nome = funcionarioAtualizado.Nome;
            }

            if (funcionarioAtualizado != null)
            {
                funcionarioBuscado.Foto = funcionarioAtualizado.Foto;
            }

            if (funcionarioAtualizado != null)
            {
                funcionarioBuscado.RG = funcionarioAtualizado.RG;
            }

        }

        public Funcionario BuscarPorId(int id)
        {
            return ctx.Funcionarios
                .Select(l => new Funcionario()
                {
                    idFuncionario = l.idFuncionario,
                    Nome = l.Nome,
                    Foto = l.Foto,
                    RG = l.RG
                })
                .FirstOrDefault(s => s.idFuncionario == id);
        }

        public void Cadastrar(Funcionario novoFuncionario)
        {
            ctx.Funcionarios.Add(novoFuncionario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Funcionarios.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public List<Funcionario> Listar()
        {
            return ctx.Funcionarios.ToList();
        }
    }
}
