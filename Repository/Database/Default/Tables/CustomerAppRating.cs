﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class CustomerAppRating
    {
        public int CustomerId { get; set; }
        [Key]
        public int BillId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public int? Rating { get; set; }
        public int? SalonId { get; set; }
        [StringLength(4000)]
        public string Services { get; set; }
        [StringLength(4000)]
        public string Products { get; set; }
        [StringLength(15)]
        public string CustomerPhone { get; set; }
        [StringLength(4000)]
        public string Departments { get; set; }
        [StringLength(4000)]
        public string Note { get; set; }
        public int? CorrectPrice { get; set; }
    }
}