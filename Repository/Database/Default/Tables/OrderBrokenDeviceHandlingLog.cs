﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class OrderBrokenDeviceHandlingLog
    {
        [Key]
        public int Id { get; set; }
        public int? OrderBrokenDeviceId { get; set; }
        public int? TypeId { get; set; }
        public int StaffEditId { get; set; }
        [StringLength(150)]
        public string Value { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
    }
}