//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetaLifeStyle
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductImage
    {
        public int ProductImageID { get; set; }
        public string ProductImageName { get; set; }
        public string ProductImagePath { get; set; }
        public int ProductID { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
