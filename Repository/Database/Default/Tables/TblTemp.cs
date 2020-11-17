﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("Tbl_Temp")]
    public partial class TblTemp
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Key { get; set; }
        [StringLength(300)]
        public string Value { get; set; }
        [StringLength(600)]
        public string Meta { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte? IsDelete { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}