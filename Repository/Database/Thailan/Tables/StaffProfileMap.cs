﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class StaffProfileMap
    {
        [Key]
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int StatusProfileId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public bool IsDelete { get; set; }
    }
}