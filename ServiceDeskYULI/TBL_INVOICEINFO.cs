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
    
    public partial class TBL_INVOICEINFO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_INVOICEINFO()
        {
            this.TBL_INVOICEDETAIL = new HashSet<TBL_INVOICEDETAIL>();
        }
    
        public int ID { get; set; }
        public string SERIALID { get; set; }
        public string SERIALNO { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public string TIME { get; set; }
        public string VAT { get; set; }
        public Nullable<int> CARI { get; set; }
        public Nullable<short> EMPLOYEE { get; set; }
    
        public virtual TBL_CARI TBL_CARI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_INVOICEDETAIL> TBL_INVOICEDETAIL { get; set; }
    }
}