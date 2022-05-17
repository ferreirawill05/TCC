using senai.darede.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.darede.WebAPI.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório ArmInstanciumRepository
    /// </summary>
    interface IArmInstanciumRepository
    {
        /// <summary>
        /// Cadastra uma nova ArmInstancia
        /// </summary>
        /// <param name="novoArmInstancia">Objeto novoArmInstancia com os novos dados</param>
        void Cadastrar(ArmInstancium novoArmInstancia);

        /// <summary>
        /// Atualiza uma ArmInstancia existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="idArmInstancia">id da ArmInstancia que será atualizado</param>
        /// <param name="armInstanciaAtualizado">Objeto ArmInstanciaAtualizado com os novos dados</param>
        void Atualizar(int idArmInstancia, ArmInstancium armInstanciaAtualizado);

        /// <summary>
        /// Busca um Arminstancia através de seu ID
        /// </summary>
        /// <param name="id">ID do ArmInstancia buscado</param>
        /// <returns>o ArmInstancia buscado</returns>
        ArmInstancium ListarId(int id);

        /// <summary>
        /// Deleta um Zona existente
        /// </summary>
        /// <param name="idArmInstancia">ID da Zona deletado</param>
        void Deletar(int idArmInstancia);
    }
}
