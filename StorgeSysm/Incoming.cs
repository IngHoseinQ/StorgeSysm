//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StorgeSysm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Incoming
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Incoming()
        {
            this.State = 0;
            this.Compart = new HashSet<Compart>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> Incoming_Date { get; set; }
        public string Supplier_Name { get; set; }
        public string Supplier_Entity { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<double> totle_pice_min { get; set; }
        public Nullable<double> totle_pice { get; set; }
        public Nullable<double> other_pr { get; set; }
        public Nullable<int> Id_typ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compart> Compart { get; set; }
        public virtual Type_Price Type_Price { get; set; }
    }
}
