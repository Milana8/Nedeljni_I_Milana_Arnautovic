//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zadatak_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblManager
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblManager()
        {
            this.tblProjects = new HashSet<tblProject>();
        }
    
        public int ManagerID { get; set; }
        public string Email { get; set; }
        public string ReservedPassword { get; set; }
        public string LevelOfResponsibility { get; set; }
        public Nullable<int> SuccessfulProjects { get; set; }
        public string Salary { get; set; }
        public string OfficeNumber { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual tblUser tblUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProject> tblProjects { get; set; }
    }
}
