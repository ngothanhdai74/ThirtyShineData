﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class NetworkOperator
    {
        [Key]
        public int Id { get; set; }
        [StringLength(300)]
        public string NetworkName { get; set; }
        [StringLength(200)]
        public string ShortName { get; set; }
        [StringLength(300)]
        public string Url { get; set; }
        [StringLength(600)]
        public string Address { get; set; }
        [StringLength(300)]
        public string Phone { get; set; }
        [StringLength(300)]
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsResend { get; set; }
        public bool? IsDefault { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}