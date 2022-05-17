using senai.darede.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.darede.WebAPI.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório TipoInstanciumRepository
    /// </summary>
    interface ITipoInstanciumRepository
    {
        /// <summary>
        /// Cadastra uma nova TipoInstancia
        /// </summary>
        /// <param name="novoTipoInstancia">Objeto novoTipoInstancia com os novos dados</param>
        void Cadastrar(TipoInstancium novoTipoInstancia);

        /// <summary>
        /// Atualiza uma TipoInstancia existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="idTipoInstancia">id da TipoInstancia que será atualizado</param>
        /// <param name="tipoInstanciaAtualizado">Objeto tipoInstanciaAtualizado com os novos dados</param>
        void Atualizar(int idTipoInstancia, TipoInstancium tipoInstanciaAtualizado);

        /// <summary>
        /// Busca um tipoinstancia através de seu ID
        /// </summary>
        /// <param name="id">ID do TipoInstancia buscado</param>
        /// <returns>o TipoInstancia buscado</returns>
        TipoInstancium ListarId(int id);

        /// <summary>
        /// Deleta um Zona existente
        /// </summary>
        /// <param name="idTipoInstancia">ID da Zona deletado</param>
        void Deletar(int idTipoInstancia);
    }
}
