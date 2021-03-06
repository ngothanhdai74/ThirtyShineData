﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class CustomerTag
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [StringLength(1000)]
        public string Tag { get; set; }
        [Column("isDelete")]
        public bool? IsDelete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
    }
}