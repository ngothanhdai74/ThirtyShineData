﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class Call
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeleteTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }
        [StringLength(50)]
        public string Receiver { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public int? Seq { get; set; }
        [StringLength(50)]
        public string Sender { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartTime { get; set; }
        public bool? Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateTime { get; set; }
        public int? Length { get; set; }
        public bool? IsDelete { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        [StringLength(50)]
        public string Salon { get; set; }
        public int? SalonId { get; set; }
        public bool? IsAutoGenerate { get; set; }
        public int? Type { get; set; }
        public int? SubStatus { get; set; }
        [StringLength(500)]
        public string Note { get; set; }
        public int? PreviousStatus { get; set; }
        public int? CustomerStatus { get; set; }
    }
}