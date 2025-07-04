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
    
    public partial class APP_MODULES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APP_MODULES()
        {
            this.CORRELATIVES = new HashSet<CORRELATIVES>();
            this.LOGBOOK_APP = new HashSet<LOGBOOK_APP>();
            this.USER_PERMISSIONS = new HashSet<USER_PERMISSIONS>();
        }
    
        public string MODULE_ID { get; set; }
        public string MODULE_NAME { get; set; }
        public Nullable<System.DateTime> INSERTED_AT { get; set; }
        public Nullable<bool> IS_DEL { get; set; }
        public string USER_CODE { get; set; }
    
        public virtual USERS USERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CORRELATIVES> CORRELATIVES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGBOOK_APP> LOGBOOK_APP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_PERMISSIONS> USER_PERMISSIONS { get; set; }
    }
}
