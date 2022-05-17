using System;
using System.Collections.Generic;

#nullable disable

namespace senai.darede.WebAPI.Domains
{
    public partial class Software
    {
        public Software()
        {
            Infraestruturas = new HashSet<Infraestrutura>();
        }

        public byte IdSoftware { get; set; }
        public string NomeSoftware { get; set; }

        public virtual ICollection<Infraestrutura> Infraestruturas { get; set; }
    }
}
