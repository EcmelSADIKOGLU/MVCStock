﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;

    public partial class tblCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCustomer()
        {
            this.tblSale = new HashSet<tblSale>();
        }
    
        public int CustomerID { get; set; }
        [Required(ErrorMessage ="Müşteri Adı Boş Bırakılamaz")]
        [StringLength(50,ErrorMessage ="En Fazla 50 Karakter Girilebilir...")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Müşteri Soyadı Boş Bırakılamaz")]
        [StringLength(50, ErrorMessage = "En Fazla 50 Karakter Girilebilir...")]
        public string CustomerSurname { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSale> tblSale { get; set; }
    }
}