using senai.darede.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.darede.WebAPI.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório ZonaInterface
    /// </summary>
    interface IZonaRepository
    {
        /// <summary>
        /// Cadastra uma nova Zona
        /// </summary>
        /// <param name="novaZona">Objeto novaZona com os novos dados</param>
        void Cadastrar(Zona novaZona);

        /// <summary>
        /// Atualiza uma Zona existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="idZona">id da Zona que será atualizado</param>
        /// <param name="zonaAtualizada">Objeto zonaAtualizada com os novos dados</param>
        void Atualizar(int idZona, Zona zonaAtualizada);

        /// <summary>
        /// Busca uma Zona através de seu ID
        /// </summary>
        /// <param name="id">ID da Zona buscada</param>
        /// <returns>a Zona buscada</returns>
        Zona ListarId(int id);

        /// <summary>
        /// Deleta um Zona existente
        /// </summary>
        /// <param name="idZona">ID da Zona deletado</param>
        void Deletar(int idZona);
    }
}
