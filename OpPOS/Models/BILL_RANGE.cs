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
    
    public partial class BILL_RANGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BILL_RANGE()
        {
            this.BILL = new HashSet<BILL>();
        }
    
        public int BILL_RANGE_ID { get; set; }
        public string ESTABLISHMENT { get; set; }
        public string EMISSION_POINT { get; set; }
        public string DOC_TYPE { get; set; }
        public int INITIAL_RANGE { get; set; }
        public int FINAL_RANGE { get; set; }
        public int LAST_USED { get; set; }
        public bool BILL_RANGE_STATE { get; set; }
        public Nullable<System.DateTime> INSERTED_AT { get; set; }
        public Nullable<bool> IS_DEL { get; set; }
        public System.DateTime LIMIT_DATE { get; set; }
        public string CAI { get; set; }
        public string USER_CODE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL> BILL { get; set; }
        public virtual USERS USERS { get; set; }
    }
}
