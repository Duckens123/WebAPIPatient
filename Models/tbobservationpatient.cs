//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPIPatient.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbobservationpatient
    {
        public long id { get; set; }
        public Nullable<long> observationid { get; set; }
        public string createdby { get; set; }
        public Nullable<System.DateTime> datecreated { get; set; }
        public Nullable<long> refobservationid { get; set; }
    }
}
