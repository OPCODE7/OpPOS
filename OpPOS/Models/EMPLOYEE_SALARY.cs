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
    
    public partial class EMPLOYEE_SALARY
    {
        public string EMPLOYEE_SALARY_CODE { get; set; }
        public string EMPLOYEE_CODE { get; set; }
        public string SALARY_CODE { get; set; }
        public string USER_CODE { get; set; }
        public System.DateTime INSERTED_AT { get; set; }
        public bool IS_DEL { get; set; }
        public bool SALARY_STATE { get; set; }
    
        public virtual EMPLOYEES EMPLOYEES { get; set; }
        public virtual USERS USERS { get; set; }
        public virtual SALARIES SALARIES { get; set; }
    }
}
