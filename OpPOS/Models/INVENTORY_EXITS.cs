//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpPOS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class INVENTORY_EXITS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVENTORY_EXITS()
        {
            this.INVENTORY_EXIT_DETAILS = new HashSet<INVENTORY_EXIT_DETAILS>();
        }
    
        public int EXIT_ID { get; set; }
        public string EXIT_REASON { get; set; }
        public System.DateTime EXIT_DATE { get; set; }
        public string USER_CODE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTORY_EXIT_DETAILS> INVENTORY_EXIT_DETAILS { get; set; }
        public virtual USERS USERS { get; set; }
    }
}
