//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SchoolDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Pan { get; set; }
        public Nullable<int> UserType { get; set; }
        public string SchoolName { get; set; }
        public string SchoolWebsite { get; set; }
        public string SchoolGst { get; set; }
        public string SchoolLandline { get; set; }
        public string SchoolAddress { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> PlanExpiryDate { get; set; }
        public Nullable<int> PlanDays { get; set; }
        public string Password { get; set; }
        public Nullable<int> PlanId { get; set; }
        public Nullable<int> NumberOfUsers { get; set; }
        public Nullable<int> PlanAmount { get; set; }
        public Nullable<bool> IsOtpVarified { get; set; }
        public string CompanyUID { get; set; }
    }
}
