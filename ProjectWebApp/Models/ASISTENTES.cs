//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LexAbogadosWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ASISTENTES
    {
        public ASISTENTES()
        {
            this.CONTRATOS = new HashSet<CONTRATOS>();
        }
    
        public long ID_ASISTENTE { get; set; }
        public string RUT { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDO_PATERNO { get; set; }
        public string APELLIDO_MATERNO { get; set; }
        public string CARGO { get; set; }
        public string TITULO_ACADEMICO { get; set; }
        public Nullable<System.DateTime> TIMESTAMP { get; set; }
        public Nullable<long> ID_USUARIO { get; set; }
    
        public virtual USUARIOS USUARIOS { get; set; }
        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }
    }
}