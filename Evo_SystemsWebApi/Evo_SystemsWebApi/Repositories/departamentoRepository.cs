using Evo_SystemsWebApi.Context;
using Evo_SystemsWebApi.Domains;
using Evo_SystemsWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evo_SystemsWebApi.Repositories
{
    public class departamentoRepository : IdepartamentoRepository
    {

        private readonly Evo_SystemsContext ctx;
        public departamentoRepository(Evo_SystemsContext _ctx)
        {
            ctx = _ctx;
        }

        public void Atualizar(int id, Departamento departamentoAtualizado)
        {
            Departamento departamentoBuscado = ctx.Departamentos.Find(id);

            if (departamentoAtualizado != null)
            {
                departamentoAtualizado.Nome = departamentoAtualizado.Nome;
            }

            if (departamentoAtualizado != null)
            {
                departamentoAtualizado.Sigla = departamentoAtualizado.Sigla;
            }


        }

        public Departamento BuscarPorId(int id)
        {
            return ctx.Departamentos
                .Select(l => new Departamento()
                {
                    idDepartamento = l.idDepartamento,
                    Nome = l.Nome,
                    Sigla = l.Sigla
                })
                .FirstOrDefault(s => s.idDepartamento == id);
        }

        public void Cadastrar(Departamento novoDepartamento)
        {
            ctx.Departamentos.Add(novoDepartamento);
            ctx.SaveChanges();
        }

        public void Cadastrar(Funcionario novoDepartamento)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            ctx.Departamentos.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public List<Departamento> Listar()
        {
            return ctx.Departamentos.ToList();
        }
    }
}
