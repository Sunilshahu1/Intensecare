//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntenseCare.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPatientDetail
    {
        public int PatientDetailId { get; set; }
        public int PatientId { get; set; }
        public string Symptoms { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> AdmitDetailId { get; set; }
    }
}
