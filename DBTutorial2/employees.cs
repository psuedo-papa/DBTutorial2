//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBTutorial2
{
    using System;
    using System.Collections.Generic;
    
    public partial class employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employees()
        {
            this.customers = new HashSet<customers>();
            this.employees1 = new HashSet<employees>();
        }
    
        public int employeeNumber { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string extension { get; set; }
        public string email { get; set; }
        public string officeCode { get; set; }
        public Nullable<int> reportsTo { get; set; }
        public string jobTitle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<customers> customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employees> employees1 { get; set; }
        public virtual employees employees2 { get; set; }
        public virtual offices offices { get; set; }
    }
}
