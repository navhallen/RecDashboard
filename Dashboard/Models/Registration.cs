//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dashboard.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registration
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string age { get; set; }
        public string contact { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string program_name { get; set; }
        public string location { get; set; }
        public string payment_type { get; set; }
        public string recreational_interest { get; set; }
        public string special_needs { get; set; }
        public string exception_goals { get; set; }
        public string allergies { get; set; }
        public int ParticipantId { get; set; }
    
        public virtual Participant Participant { get; set; }
    }
}
