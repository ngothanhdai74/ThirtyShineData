﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Customer_Hair_Skin_History")]
    public partial class CustomerHairSkinHistory
    {
        [Key]
        public int Id { get; set; }
        [Column("Hair_Att_Ids")]
        [StringLength(250)]
        public string HairAttIds { get; set; }
        [Column("Skin_Att_Ids")]
        [StringLength(250)]
        public string SkinAttIds { get; set; }
        public int? CustomerId { get; set; }
        public bool? IsDelete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}