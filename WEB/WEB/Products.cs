//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace REALTEST
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string Detail { get; set; }
        public string ProductImage { get; set; }
        public int CategoryId { get; set; }
    
        public virtual Categories Categories { get; set; }
    }
}
