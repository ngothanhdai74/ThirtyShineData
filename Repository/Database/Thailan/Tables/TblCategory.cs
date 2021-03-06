﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Tbl_Category")]
    public partial class TblCategory
    {
        [Key]
        public int Id { get; set; }
        public int? Pid { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(600)]
        public string Description { get; set; }
        [StringLength(600)]
        public string Meta { get; set; }
        public bool? Publish { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedTime { get; set; }
        public byte? IsDelete { get; set; }
        public int? Order { get; set; }
        public string Images { get; set; }
        [StringLength(400)]
        public string Thumb { get; set; }
        public int? OnWebId { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}