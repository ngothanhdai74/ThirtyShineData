﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class StoreQrScan
    {
        [Key]
        public int Id { get; set; }
        public int? BillId { get; set; }
        [StringLength(255)]
        public string MacAddress { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScanDate { get; set; }
        public int? ScanDateInt { get; set; }
        [StringLength(255)]
        public string ScanDateString { get; set; }
        [StringLength(255)]
        public string Salon { get; set; }
        public int? StylistId { get; set; }
    }
}