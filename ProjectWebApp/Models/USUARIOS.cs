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
    
    public partial class USUARIOS
    {
        public USUARIOS()
        {
            this.ASISTENTES = new HashSet<ASISTENTES>();
            this.CLIENTES = new HashSet<CLIENTES>();
            this.PRESUPUESTO = new HashSet<PRESUPUESTO>();
        }
    
        public string USER { get; set; }
        public string PASS { get; set; }
        public Nullable<System.DateTime> TIMESTAMP { get; set; }
        public long ID_ROL { get; set; }
        public long ID_USUARIO { get; set; }
        public string CORREO { get; set; }
        public string CORREO_SEC { get; set; }
        public string IP { get; set; }
        public string IMG_PROFILE { get; set; }
        public byte[] BINARY_IMAGE { get; set; }
    
        public virtual ICollection<ASISTENTES> ASISTENTES { get; set; }
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }
        public virtual TIPO_ROL TIPO_ROL { get; set; }
        public virtual ICollection<PRESUPUESTO> PRESUPUESTO { get; set; }
    }
}
