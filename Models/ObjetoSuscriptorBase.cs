using System;
using System.ComponentModel.DataAnnotations;

namespace asp_net_core.Models
{
    public abstract class ObjetoSuscriptorBase
    {
        public string Id { get; set; }
        
        public virtual string Nombre { get; set; }

        public virtual string Apellido { get; set; }

        public ObjetoSuscriptorBase()
        {
            
        }

        public override string ToString()
        {
            return $"{Nombre}, {Id}"; 
        }
    }
}