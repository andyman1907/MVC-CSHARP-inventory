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
    
    public partial class tb_role_user
    {
        public long rolu_id { get; set; }
        public long rolu_role_id { get; set; }
        public long rolu_user_id { get; set; }
        public Nullable<System.DateTime> rolu_lastUpdate { get; set; }
        public long rolu_status { get; set; }
    
        public virtual tb_role tb_role { get; set; }
        public virtual tb_users tb_users { get; set; }
        public virtual tb_state tb_state { get; set; }
    }
}
