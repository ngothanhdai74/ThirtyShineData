﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class Users
    {
        [Key]
        [StringLength(50)]
        public string UserId { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string LastPassword { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLogin { get; set; }
        public bool? IsActive { get; set; }
        public bool? FirstLogin { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastChangePassword { get; set; }
        public int? TimeLivePassword { get; set; }
        public bool? IsDelete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public int? StaffId { get; set; }
        [Column("Valid2FA")]
        public bool? Valid2Fa { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        [StringLength(300)]
        public string OtpChangePass { get; set; }
        [Column("RequiredValid2FA")]
        public bool? RequiredValid2Fa { get; set; }
    }
}