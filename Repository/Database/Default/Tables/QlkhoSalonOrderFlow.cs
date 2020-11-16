﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("QLKho_SalonOrder_Flow")]
    public partial class QlkhoSalonOrderFlow
    {
        [Key]
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Cost { get; set; }
        public int? Price { get; set; }
        public int? QuantityOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
        public int? QuantityReceived { get; set; }
        public int? QuantityOwe { get; set; }
        public int? QuantityExport { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}