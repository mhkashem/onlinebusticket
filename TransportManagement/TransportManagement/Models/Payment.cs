//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransportManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int PayId { get; set; }
        public string PaymentSystem { get; set; }
        public string Code { get; set; }
        public Nullable<int> PassengerId { get; set; }
    
        public virtual User User { get; set; }
    }
}
