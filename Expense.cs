//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnterpriseCourseworkTwo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Expense
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string isRecurring { get; set; }
        public string Date { get; set; }
        public int UserId { get; set; }
        public int ContactId { get; set; }
    
        public virtual User User { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
