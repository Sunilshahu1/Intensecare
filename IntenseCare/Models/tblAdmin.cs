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
    
    public partial class tblAdmin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Emailid { get; set; }
        public string ContactNo { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsInsert { get; set; }
        public bool IsEdit { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<bool> IsSuper { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}
