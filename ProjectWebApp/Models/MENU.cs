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
    
    public partial class MENU
    {
        public MENU()
        {
            this.MENU_SUB = new HashSet<MENU_SUB>();
        }
    
        public long MENU_ID { get; set; }
        public string TEXTO { get; set; }
        public string REFERENCIA { get; set; }
        public Nullable<long> ID_ROL { get; set; }
        public Nullable<long> ORDEN { get; set; }
        public string CONTROLLER { get; set; }
        public string ACTION { get; set; }
    
        public virtual TIPO_ROL TIPO_ROL { get; set; }
        public virtual ICollection<MENU_SUB> MENU_SUB { get; set; }
    }
}
