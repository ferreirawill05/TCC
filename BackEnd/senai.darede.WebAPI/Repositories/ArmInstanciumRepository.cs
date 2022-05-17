using senai.darede.WebAPI.Contexts;
using senai.darede.WebAPI.Domains;
using senai.darede.WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.darede.WebAPI.Repositories
{
    public class ArmInstanciumRepository : IArmInstanciumRepository
    {
        DaredeContext ctx = new DaredeContext();
        public ArmInstancium ListarId(int id)
        {
            return ctx.ArmInstancia.FirstOrDefault(c => c.IdArmInstancia == id);
        }

        public void Atualizar(int idArmInstancia, ArmInstancium ArmInstanciaAtualizado)
        {
            ArmInstancium armInstanciaBuscado = ListarId(idArmInstancia);

            if (armInstanciaBuscado != null)
            {
                armInstanciaBuscado.IdArmInstancia = ArmInstanciaAtualizado.IdArmInstancia;
                armInstanciaBuscado.TipoArmInstancia = ArmInstanciaAtualizado.TipoArmInstancia;
            }

            ctx.ArmInstancia.Update(armInstanciaBuscado);
            ctx.SaveChanges();
        }

        public void Cadastrar(ArmInstancium novoArmInstancia)
        {
            ctx.ArmInstancia.Add(novoArmInstancia);
            ctx.SaveChanges();
        }

        public void Deletar(int idArmInstancia)
        {
            ArmInstancium armInstanciaBuscado = ListarId(idArmInstancia);
            ctx.ArmInstancia.Remove(armInstanciaBuscado);
            ctx.SaveChanges();
        }
    }
}
