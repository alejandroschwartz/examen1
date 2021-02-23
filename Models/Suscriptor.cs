using System;
using System.Collections.Generic;

namespace asp_net_core.Models
{
    public class Suscriptor: ObjetoSuscriptorBase
    {
        public int NumeroDocumento {get; set;} 

        public string Dirección { get; set; }
        
        public string Email { get; set; }
        
        public string NombreUsuario { get; set; }

        public string Password { get; set; }
        
        public TiposDocumento TipoDocumento { get; set; }

        public Suscriptor()
        {
            
        }
    }
}