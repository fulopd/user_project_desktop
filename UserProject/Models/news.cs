//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class news
    {
        public int id { get; set; }
        public int author { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public bool @public { get; set; }
        public System.DateTime creation_date { get; set; }
    
        public virtual user_data user_data { get; set; }
    }
}
