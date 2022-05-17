using senai.darede.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.darede.WebAPI.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório Infraestrutura
    /// </summary>
    interface IInfraestruturaRepository
    {
        /// <summary>
        /// Cadastra uma nova Infraestrutura
        /// </summary>
        /// <param name="novaInfraestrutura">Objeto novaInfraestrutura com os novos dados</param>
        void Cadastrar(Infraestrutura novaInfraestrutura);

        /// <summary>
        /// Atualiza uma Infraestrutura existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="idInfraestrutura">id da Infraestrutura que será atualizada</param>
        /// <param name="infraestruturaAtualizada">Objeto InfraestruturaAtualizada com os novos dados</param>
        void Atualizar(int idInfraestrutura, Infraestrutura infraestruturaAtualizada);

        /// <summary>
        /// Busca uma Infraestrutura através de seu ID
        /// </summary>
        /// <param name="id">ID do Infraestrutura buscado</param>
        /// <returns>A infraestrutura buscada</returns>
        Infraestrutura ListarId(int id);

        /// <summary>
        /// Deleta uma Infraestrutura existente
        /// </summary>
        /// <param name="idInfraestrutura">ID da Infraestrutura deletado</param>
        void Deletar(int idInfraestrutura);

        /// <summary>
        /// Lista as Infraestruturas do usuário
        /// </summary>
        /// <param name="idUsuario">ID do Usuario que terá a infraestruturas listadas</param>
        public List<Infraestrutura> MinhasInfraestruturas(int idUsuario);
    }
}
