//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication10
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seat_Details
    {
        public string Ticket_Id { get; set; }
        public string Seat_No { get; set; }
    
        public virtual Booking_Details Booking_Details { get; set; }
    }
}
