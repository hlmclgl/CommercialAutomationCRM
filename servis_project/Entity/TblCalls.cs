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
    
    public partial class TblCalls
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblCalls()
        {
            this.TblCallDetails = new HashSet<TblCallDetails>();
        }
    
        public int ID { get; set; }
        public Nullable<int> CallFirm { get; set; }
        public string Issue { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> CallStaff { get; set; }
    
        public virtual TblFirms TblFirms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblCallDetails> TblCallDetails { get; set; }
        public virtual TblStaffs TblStaffs { get; set; }
    }
}
