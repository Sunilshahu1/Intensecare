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
    
    public partial class tblDoctor
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public System.DateTime DOB { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Degree { get; set; }
        public Nullable<int> YearOfExperience { get; set; }
        public bool IsActive { get; set; }
        public bool IsVerified { get; set; }
        public bool IsMobileVerified { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
        public string Specialization { get; set; }
    }
}
