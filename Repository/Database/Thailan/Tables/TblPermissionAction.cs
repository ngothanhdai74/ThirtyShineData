﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Tbl_Permission_Action")]
    public partial class TblPermissionAction
    {
        [Key]
        [Column("aID")]
        public int AId { get; set; }
        [Column("aName")]
        [StringLength(150)]
        public string AName { get; set; }
        [Column("aDescription")]
        public string ADescription { get; set; }
        [Column("aPublish")]
        public bool? APublish { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}