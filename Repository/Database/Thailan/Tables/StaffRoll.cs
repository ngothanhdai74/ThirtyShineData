﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Staff_Roll")]
    public partial class StaffRoll
    {
        [Key]
        public int Id { get; set; }
        public int StaffId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}