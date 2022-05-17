using System;
using System.Collections.Generic;

#nullable disable

namespace senai.darede.WebAPI.Domains
{
    public partial class Instancium
    {
        public Instancium()
        {
            Infraestruturas = new HashSet<Infraestrutura>();
        }

        public short IdInstancia { get; set; }
        public byte? IdArmInstancia { get; set; }
        public short? IdTipoInstancia { get; set; }
        public string VCpu { get; set; }
        public string MemoriaGib { get; set; }

        public virtual ArmInstancium IdArmInstanciaNavigation { get; set; }
        public virtual TipoInstancium IdTipoInstanciaNavigation { get; set; }
        public virtual ICollection<Infraestrutura> Infraestruturas { get; set; }
    }
}
