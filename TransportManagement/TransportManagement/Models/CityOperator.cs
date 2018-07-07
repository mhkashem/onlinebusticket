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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class CityOperator
    {
        public int CityId { get; set; }
        [DisplayName("From")]
        [Required(ErrorMessage = "Required")]
        public string City_From { get; set; }
        [DisplayName("To")]
        [Required(ErrorMessage = "Required")]
        public string City_To { get; set; }
        [DisplayName("Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Required")]
        public string Dtate { get; set; }
        public string Operator { get; set; }
        public string Dept_Time { get; set; }
        public string Arr_Time { get; set; }
        public string Seat { get; set; }
        public string Fare { get; set; }
        public string Details { get; set;}
    }
}
