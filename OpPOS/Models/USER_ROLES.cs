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
    
    public partial class USER_ROLES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER_ROLES()
        {
            this.ROLE_PERMISSIONS = new HashSet<ROLE_PERMISSIONS>();
            this.USERS = new HashSet<USERS>();
        }
    
        public int ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string DESCRIPTION_ROLE { get; set; }
        public System.DateTime INSERTED_AT { get; set; }
        public bool IS_DEL { get; set; }
        public string USER_CODE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROLE_PERMISSIONS> ROLE_PERMISSIONS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USERS> USERS { get; set; }
        public virtual USERS USERS1 { get; set; }
    }
}
