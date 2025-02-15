//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebThucPham.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Cat_ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Nullable<int> Discount { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public Nullable<bool> BestSeller { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Describe { get; set; }
        public Nullable<int> Instock { get; set; }
        public Nullable<System.DateTime> CreatAt { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
