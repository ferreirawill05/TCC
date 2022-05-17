using senai.darede.WebAPI.Contexts;
using senai.darede.WebAPI.Domains;
using senai.darede.WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.darede.WebAPI.Repositories
{
    public class TipoInstanciumRepository : ITipoInstanciumRepository
    {
        DaredeContext ctx = new DaredeContext();
        public TipoInstancium ListarId(int id)
        {
            return ctx.TipoInstancia.FirstOrDefault(c => c.IdTipoInstancia == id);
        }

        public void Atualizar(int idTipoInstancia, TipoInstancium tipoInstanciaAtualizado)
        {
            TipoInstancium tipoInstanciaBuscado = ListarId(idTipoInstancia);

            if (tipoInstanciaBuscado != null)
            {
                tipoInstanciaBuscado.IdTipoInstancia = tipoInstanciaAtualizado.IdTipoInstancia;
                tipoInstanciaBuscado.NomeTipoInstancia = tipoInstanciaAtualizado.NomeTipoInstancia;
            }

            ctx.TipoInstancia.Update(tipoInstanciaBuscado);
            ctx.SaveChanges();
        }

        public void Cadastrar(TipoInstancium novoTipoInstancia)
        {
            ctx.TipoInstancia.Add(novoTipoInstancia);
            ctx.SaveChanges();
        }

        public void Deletar(int idTipoInstancia)
        {
            TipoInstancium tipoInstanciaBuscado = ListarId(idTipoInstancia);
            ctx.TipoInstancia.Remove(tipoInstanciaBuscado);
            ctx.SaveChanges();
        }
    }
}
