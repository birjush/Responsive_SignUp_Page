//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ins_fetch_entity.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLEmployee
    {
        public int id_pk { get; set; }
        public Nullable<int> employeeId { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public Nullable<System.DateTime> dateofbirth { get; set; }
    }
}
