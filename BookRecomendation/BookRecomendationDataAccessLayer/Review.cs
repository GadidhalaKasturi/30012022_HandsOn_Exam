//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookRecomendationDataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public Nullable<int> book_isbn { get; set; }
        public int rating { get; set; }
        public string review1 { get; set; }
    
        public virtual Book Book { get; set; }
    }
}
