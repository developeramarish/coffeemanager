//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeHome.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill_Online
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill_Online()
        {
            this.Bill_Online_Detail = new HashSet<Bill_Online_Detail>();
        }
    
        public string name_customer { get; set; }
        public string address { get; set; }
        public Nullable<int> total_price { get; set; }
        public Nullable<int> sdt { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public int id_bill_online { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill_Online_Detail> Bill_Online_Detail { get; set; }
    }
}
