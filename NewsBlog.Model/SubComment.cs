//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsBlog.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubComment
    {
        public int Id { get; set; }
        public int ParentComment { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Comment Comment { get; set; }
        public virtual User User { get; set; }
    }
}
