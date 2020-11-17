﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class CustomerDevice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string DeviceId { get; set; }
        [Required]
        [Column("OS")]
        [StringLength(10)]
        public string Os { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public bool IsDelete { get; set; }
        public int CustomerId { get; set; }
    }
}