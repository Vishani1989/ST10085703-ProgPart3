//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgPart3CMCS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Claim
    {
        public string ClaimID { get; set; }
        public System.DateTime SubmittedDate { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string DocumentPath { get; set; }
        public string Status { get; set; }
        public string UserID { get; set; }
    }
}