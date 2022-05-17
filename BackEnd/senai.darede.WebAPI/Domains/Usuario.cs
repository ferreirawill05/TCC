using System;
using System.Collections.Generic;

#nullable disable

namespace senai.darede.WebAPI.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Infraestruturas = new HashSet<Infraestrutura>();
        }

        public int IdUsuario { get; set; }
        public byte? IdTipoUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Infraestrutura> Infraestruturas { get; set; }
    }
}
