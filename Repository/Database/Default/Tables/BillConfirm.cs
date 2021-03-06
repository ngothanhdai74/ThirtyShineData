﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class BillConfirm
    {
        [Key]
        public int Id { get; set; }
        public int? BillId { get; set; }
        public string ServiceIds { get; set; }
        public string ProductIds { get; set; }
        public long? SentTime { get; set; }
        public int? TotalMoney { get; set; }
        public int CustomerConfirm { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}