//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBlibraryTH
{
    using System;
    using System.Collections.Generic;
    
    public partial class ToolBooking
    {
        public int OrderID { get; set; }
        public int CusID { get; set; }
        public int ToolID { get; set; }
        public System.DateTime CheckOutDate { get; set; }
        public System.DateTime CheckInDate { get; set; }
        public System.DateTime ActualCheckInDate { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
