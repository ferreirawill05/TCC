using senai.darede.WebAPI.Contexts;
using senai.darede.WebAPI.Domains;
using senai.darede.WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.darede.WebAPI.Repositories
{
    public class SoftwareRepository : ISoftwareRepository
    {
        DaredeContext ctx = new DaredeContext();
        public Software ListarId(int id)
        {
            return ctx.Softwares.FirstOrDefault(c => c.IdSoftware == id);
        }

        public void Atualizar(int idSoftware, Software softwareAtualizado)
        {
            Software softwareBuscado = ListarId(idSoftware);

            if (softwareBuscado != null)
            {
                softwareBuscado.IdSoftware = softwareAtualizado.IdSoftware;
                softwareBuscado.NomeSoftware = softwareAtualizado.NomeSoftware;
            }

            ctx.Softwares.Update(softwareBuscado);
            ctx.SaveChanges();
        }

        public void Cadastrar(Software novoSoftware)
        {
            ctx.Softwares.Add(novoSoftware);
            ctx.SaveChanges();
        }

        public void Deletar(int idSoftware)
        {
            Software softwareBuscado = ListarId(idSoftware);
            ctx.Softwares.Remove(softwareBuscado);
            ctx.SaveChanges();
        }
    }
}
