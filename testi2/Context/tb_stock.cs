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
    
    public partial class tb_stock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_stock()
        {
            this.tb_sale_detail = new HashSet<tb_sale_detail>();
        }
    
        public long sto_id { get; set; }
        public string sto_descript { get; set; }
        public long sto_state { get; set; }
        public long sto_avaible { get; set; }
        public decimal sto_buyPrice { get; set; }
        public decimal sto_salePrice { get; set; }
        public string sto_url { get; set; }
        public long sto_provId { get; set; }
        public long sto_category { get; set; }
    
        public virtual tb_category tb_category { get; set; }
        public virtual tb_provider tb_provider { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_sale_detail> tb_sale_detail { get; set; }
        public virtual tb_state tb_state { get; set; }
    }
}