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
    
    public partial class tb_role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_role()
        {
            this.tb_role_user = new HashSet<tb_role_user>();
        }
    
        public long role_id { get; set; }
        public string role_descript { get; set; }
        public long role_status { get; set; }
    
        public virtual tb_state tb_state { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_role_user> tb_role_user { get; set; }
    }
}
