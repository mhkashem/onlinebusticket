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
    
    public partial class Cancel
    {
        public int CancelId { get; set; }
        public Nullable<int> PassengerId { get; set; }
        public string TicketPNR { get; set; }
        public string TicketNo { get; set; }
        public string Phone { get; set; }
        public Nullable<int> TicketId { get; set; }
    
        public virtual Ticket Ticket { get; set; }
    }
}