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
    
    public partial class tb_sale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_sale()
        {
            this.tb_bill = new HashSet<tb_bill>();
            this.tb_sale_detail = new HashSet<tb_sale_detail>();
        }
    
        public long sal_id { get; set; }
        public long sal_userId { get; set; }
        public long sal_cli_id { get; set; }
        public System.DateTime sal_date { get; set; }
        public long sal_state { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_bill> tb_bill { get; set; }
        public virtual tb_clients tb_clients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_sale_detail> tb_sale_detail { get; set; }
        public virtual users tb_users { get; set; }
        public virtual tb_state tb_state { get; set; }
    }
}
