//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testi2.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_profile
    {
        public long prof_id { get; set; }
        public string prof_name { get; set; }
        public long prof_status { get; set; }
    
        public virtual tb_state tb_state { get; set; }
    }
}
