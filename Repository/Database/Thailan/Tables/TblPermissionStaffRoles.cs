﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Tbl_Permission_Staff_Roles")]
    public partial class TblPermissionStaffRoles
    {
        [Key]
        public int Id { get; set; }
        public int? PermissionId { get; set; }
        [StringLength(150)]
        public string PermissionName { get; set; }
        public int? StaffId { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}