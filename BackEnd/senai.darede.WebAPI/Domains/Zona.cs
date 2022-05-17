using System;
using System.Collections.Generic;

#nullable disable

namespace senai.darede.WebAPI.Domains
{
    public partial class Zona
    {
        public Zona()
        {
            Infraestruturas = new HashSet<Infraestrutura>();
        }

        public byte IdZona { get; set; }
        public string NomeZona { get; set; }

        public virtual ICollection<Infraestrutura> Infraestruturas { get; set; }
    }
}
