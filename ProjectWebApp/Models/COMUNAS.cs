//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMUNAS
    {
        public COMUNAS()
        {
            this.CLIENTES = new HashSet<CLIENTES>();
        }
    
        public long ID_COMUNA { get; set; }
        public string COMUNA { get; set; }
        public Nullable<long> ID_REGION { get; set; }
    
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }
        public virtual REGIONES REGIONES { get; set; }
    }
}
