﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class PermissionMenuAction
    {
        public int Id { get; set; }
        public int? PermissionId { get; set; }
        public int? PageId { get; set; }
        public int? ActionId { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}