﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class BookingSalonBackup
    {
        public int Id { get; set; }
        public int? SalonId { get; set; }
        public int? SalonBackupId { get; set; }
        public bool IsDelete { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}