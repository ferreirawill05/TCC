using Microsoft.EntityFrameworkCore;
using senai.darede.WebAPI.Contexts;
using senai.darede.WebAPI.Domains;
using senai.darede.WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.darede.WebAPI.Repositories
{
    public class InfraestruturaRepository : IInfraestruturaRepository
    {
        DaredeContext ctx = new DaredeContext();

        public void Atualizar(int idInfraestrutura, Infraestrutura infraestruturaAtualizada)
        {
            Infraestrutura infraestruturaBuscada= ListarId(idInfraestrutura);

            if (infraestruturaBuscada != null)
            {
                infraestruturaBuscada.IdInfraestrutura = infraestruturaAtualizada.IdInfraestrutura;
                infraestruturaBuscada.IdUsuario = infraestruturaAtualizada.IdUsuario;
                infraestruturaBuscada.IdInstancia = infraestruturaAtualizada.IdInstancia;
                infraestruturaBuscada.IdSoftware = infraestruturaAtualizada.IdSoftware;
                infraestruturaBuscada.TopologiaImagem = infraestruturaAtualizada.TopologiaImagem;
                infraestruturaBuscada.IpPrivado = infraestruturaAtualizada.IpPrivado;
                infraestruturaBuscada.MascaraPrivado = infraestruturaAtualizada.MascaraPrivado;
                infraestruturaBuscada.IpPublico = infraestruturaAtualizada.IpPublico;
                infraestruturaBuscada.MascaraPublico = infraestruturaAtualizada.MascaraPublico;
                infraestruturaBuscada.Gateway = infraestruturaAtualizada.Gateway;
                infraestruturaBuscada.MascaraGateway = infraestruturaAtualizada.MascaraGateway;
                infraestruturaBuscada.Ativo = infraestruturaAtualizada.Ativo;
            }

            ctx.Infraestruturas.Update(infraestruturaBuscada);
            ctx.SaveChanges();
        }

        public void Cadastrar(Infraestrutura novaInfraestrutura)
        {
            ctx.Infraestruturas.Add(novaInfraestrutura);
            ctx.SaveChanges();
        }

        public void Deletar(int idInfraestrutura)
        {
            Infraestrutura infraestruturaBuscada = ListarId(idInfraestrutura);

            ctx.Infraestruturas.Remove(infraestruturaBuscada);

            ctx.SaveChanges();
        }

        public Infraestrutura ListarId(int id)
        {
            return ctx.Infraestruturas.FirstOrDefault(c => c.IdInfraestrutura == id);
        }

        public List<Infraestrutura> MinhasInfraestruturas(int idUsuario)
        {
            return ctx.Infraestruturas
                .Include(p => p.IdUsuarioNavigation)
                .Where(p => p.IdUsuario == idUsuario)
                .ToList();
        }

        public List<Infraestrutura> InfraestruturasAtivo(bool Ativo)
        {
            return ctx.Infraestruturas
                .Where(p => p.Ativo == Ativo)
                .ToList();
        }
    }
}
