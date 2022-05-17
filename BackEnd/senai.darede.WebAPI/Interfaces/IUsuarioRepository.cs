using senai.darede.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.darede.WebAPI.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório UsuarioRepository
    /// </summary>
    interface IUsuarioRepository
    {
        /// <summary>
        /// Cadastra um novo Usuario
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario com os novos dados</param>
        void Cadastrar(Usuario novoUsuario);

        /// <summary>
        /// Atualiza um Usuario existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="idUsuario">id do Usuario que será atualizado</param>
        /// <param name="usuarioAtualizado">Objeto UsuarioAtualizado com os novos dados</param>
        void Atualizar(int idUsuario, Usuario usuarioAtualizado);

        /// <summary>
        /// Busca um Usuario através de seu ID
        /// </summary>
        /// <param name="id">ID do Usuario buscado</param>
        /// <returns>O Usuario buscado</returns>
        Usuario ListarId(int id);

        /// <summary>
        /// Deleta um Usuario existente
        /// </summary>
        /// <param name="idUsuario">ID do Usuario deletado</param>
        void Deletar(int idUsuario);

        /// <summary>
        /// Busca um usuário através de seu email e senha
        /// </summary>
        /// <param name="email">Email do usuário buscado</param>
        /// <param name="senha">Senha do usuário buscado</param>
        /// <returns>Usuário buscado</returns>
        Usuario Login(string email, string senha);

    }
}
