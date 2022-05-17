using senai.darede.WebAPI.Contexts;
using senai.darede.WebAPI.Domains;
using senai.darede.WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.darede.WebAPI.Repositories
{
    public class ZonaRepository : IZonaRepository
    {

        DaredeContext ctx = new DaredeContext();
        public Zona ListarId(int id)
        {
            return ctx.Zonas.FirstOrDefault(c => c.IdZona == id);
        }

        public void Atualizar(int idZona, Zona zonaAtualizada)
        {
            Zona zonaBuscada = ListarId(idZona);

            if (zonaBuscada != null)
            {
                zonaBuscada.IdZona = zonaAtualizada.IdZona;
                zonaBuscada.NomeZona = zonaAtualizada.NomeZona;
            }

            ctx.Zonas.Update(zonaBuscada);
            ctx.SaveChanges();
        }

        public void Cadastrar(Zona novaZona)
        {
            ctx.Zonas.Add(novaZona);
            ctx.SaveChanges();
        }

        public void Deletar(int idZona)
        {
            Zona zonaBuscada = ListarId(idZona);
            ctx.Zonas.Remove(zonaBuscada);
            ctx.SaveChanges();
        }

    }
}
