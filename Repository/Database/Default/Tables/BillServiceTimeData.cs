﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class BillServiceTimeData
    {
        [Key]
        public int BillId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SkinnerStartSensorTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SkinnerEndSensorTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedTime { get; set; }
        public bool? IsDeleted { get; set; }
    }
}