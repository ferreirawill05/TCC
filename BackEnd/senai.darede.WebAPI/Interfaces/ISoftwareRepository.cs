using senai.darede.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.darede.WebAPI.Interfaces
{
        /// <summary>
        /// Interface responsável pelo repositório SoftwareInterface
        /// </summary>
    interface ISoftwareRepository
    {
            /// <summary>
            /// Cadastra um novo Software
            /// </summary>
            /// <param name="novoSoftware">Objeto novoSoftware com os novos dados</param>
            void Cadastrar(Software novoSoftware);

            /// <summary>
            /// Atualiza um Software existente passando o id pela URL da requisição
            /// </summary>
            /// <param name="idSoftware">id do Software que será atualizado</param>
            /// <param name="softwareAtualizado">Objeto softwareAtualizado com os novos dados</param>
            void Atualizar(int idSoftware, Software softwareAtualizado);

            /// <summary>
            /// Busca um Software através de seu ID
            /// </summary>
            /// <param name="id">ID do Software buscado</param>
            /// <returns>O Software buscado</returns>
            Software ListarId(int id);

            /// <summary>
            /// Deleta um Software existente
            /// </summary>
            /// <param name="idSoftware">ID do Software deletado</param>
            void Deletar(int idSoftware);

        }
    }

