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
    
    public partial class tblAdmitDetail
    {
        public int AdmitDetailId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int NurseId { get; set; }
        public string WardType { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int WardNo { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public bool IsDischarge { get; set; }
    }
}
