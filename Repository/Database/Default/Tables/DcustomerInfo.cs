﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("DCustomerInfo")]
    public partial class DcustomerInfo
    {
        [Key]
        public int CustomerId { get; set; }
        [Key]
        [StringLength(20)]
        public string CustomerPhone { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        public bool? CustomerGender { get; set; }
        public bool CustomerIsMarry { get; set; }
        public double CustomerScore { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CustomerBirthday { get; set; }
        public int? CustomerCareerId { get; set; }
        public int? TotalMoneyOfBill { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastOfBill { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateFirstOfBill { get; set; }
        public bool? UsedToPayByCard { get; set; }
        public int? TotalOfBill { get; set; }
    }
}