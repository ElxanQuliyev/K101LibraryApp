//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace K101BookApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book_To_Reader
    {
        public int ID { get; set; }
        public Nullable<int> BookId { get; set; }
        public Nullable<int> ReaderId { get; set; }
        public Nullable<System.DateTime> TakeDate { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Reader Reader { get; set; }
    }
}