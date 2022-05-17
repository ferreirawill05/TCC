using System;
using System.Collections.Generic;

#nullable disable

namespace senai.darede.WebAPI.Domains
{
    public partial class TipoInstancium
    {
        public TipoInstancium()
        {
            Instancia = new HashSet<Instancium>();
        }

        public short IdTipoInstancia { get; set; }
        public string NomeTipoInstancia { get; set; }

        public virtual ICollection<Instancium> Instancia { get; set; }
    }
}
