//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace servis_project.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblStaffs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblStaffs()
        {
            this.TblTasks = new HashSet<TblTasks>();
            this.TblTasks1 = new HashSet<TblTasks>();
            this.TblCalls = new HashSet<TblCalls>();
        }
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public Nullable<int> Department { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Roles { get; set; }
    
        public virtual TblDepartments TblDepartments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblTasks> TblTasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblTasks> TblTasks1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblCalls> TblCalls { get; set; }
    }
}
