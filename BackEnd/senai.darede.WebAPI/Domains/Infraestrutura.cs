using System;
using System.Collections.Generic;

#nullable disable

namespace senai.darede.WebAPI.Domains
{
    public partial class Infraestrutura
    {
        public int IdInfraestrutura { get; set; }
        public int? IdUsuario { get; set; }
        public short? IdInstancia { get; set; }
        public byte? IdSoftware { get; set; }
        public byte? IdZona { get; set; }
        public string TopologiaImagem { get; set; }
        public string IpPrivado { get; set; }
        public string MascaraPrivado { get; set; }
        public string IpPublico { get; set; }
        public string MascaraPublico { get; set; }
        public string Gateway { get; set; }
        public string MascaraGateway { get; set; }
        public bool? Ativo { get; set; }

        public virtual Instancium IdInstanciaNavigation { get; set; }
        public virtual Software IdSoftwareNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual Zona IdZonaNavigation { get; set; }
    }
}
