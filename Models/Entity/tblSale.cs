//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCStock.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSale
    {
        public int SaleID { get; set; }
        public Nullable<int> SaleProduct { get; set; }
        public Nullable<int> SaleCustomer { get; set; }
        public Nullable<byte> SalePiece { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
    
        public virtual tblCustomer tblCustomer { get; set; }
        public virtual tblProduct tblProduct { get; set; }
    }
}