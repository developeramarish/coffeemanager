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
    
    public partial class Bill_details
    {
        public int id_bill { get; set; }
        public int id_food { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual DrinkAndDessert DrinkAndDessert { get; set; }
    }
}
