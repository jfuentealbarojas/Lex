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
    
    public partial class PRESUPUESTO
    {
        public PRESUPUESTO()
        {
            this.CONTRATOS = new HashSet<CONTRATOS>();
            this.DOCUMENTOS = new HashSet<DOCUMENTOS>();
        }
    
        public long ID_PRESUPUESTO { get; set; }
        public string COD_SOLICITUD { get; set; }
        public System.DateTime FECHA { get; set; }
        public string ESTADO_AVANCE { get; set; }
        public string CONTRATADO { get; set; }
        public string OBSERVACIONES { get; set; }
        public long ID_ASISTENTE { get; set; }
        public long ID_CAUSAL { get; set; }
        public Nullable<long> ID_USUARIO { get; set; }
    
        public virtual CAUSALES CAUSALES { get; set; }
        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }
        public virtual ICollection<DOCUMENTOS> DOCUMENTOS { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
    }
}
