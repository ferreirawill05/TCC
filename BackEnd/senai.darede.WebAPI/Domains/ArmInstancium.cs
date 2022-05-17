using System;
using System.Collections.Generic;

#nullable disable

namespace senai.darede.WebAPI.Domains
{
    public partial class ArmInstancium
    {
        public ArmInstancium()
        {
            Instancia = new HashSet<Instancium>();
        }

        public byte IdArmInstancia { get; set; }
        public string TipoArmInstancia { get; set; }

        public virtual ICollection<Instancium> Instancia { get; set; }
    }
}
