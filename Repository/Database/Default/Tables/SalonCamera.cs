﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class SalonCamera
    {
        [Key]
        public int Id { get; set; }
        public int? SalonId { get; set; }
        [StringLength(100)]
        public string IpAddress { get; set; }
        public int? Channel { get; set; }
        [StringLength(100)]
        public string Username { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
        public int? Port { get; set; }
        public int? DepartmentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
    }
}