//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceDeskYULI
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_EMPLOYEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_EMPLOYEE()
        {
            this.TBL_PRODUCTACCEPT = new HashSet<TBL_PRODUCTACCEPT>();
        }
    
        public short ID { get; set; }
        public string NAME { get; set; }
        public string LASTNAME { get; set; }
        public Nullable<byte> DEPARTMENT { get; set; }
        public string PICTURE { get; set; }
        public string MAIL { get; set; }
        public string PHONE { get; set; }
        public string NATIONALITY { get; set; }
    
        public virtual TBL_DEPARTMENT TBL_DEPARTMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_PRODUCTACCEPT> TBL_PRODUCTACCEPT { get; set; }
    }
}
