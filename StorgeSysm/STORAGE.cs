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
    
    public partial class STORAGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STORAGE()
        {
            this.Parts = new HashSet<Parts>();
        }
    
        public int Id { get; set; }
        public string StoreName { get; set; }
        public string KeeperName { get; set; }
        public string deckTitle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parts> Parts { get; set; }
    }
}
