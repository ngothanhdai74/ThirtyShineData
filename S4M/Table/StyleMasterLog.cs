﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class StyleMasterLog
    {
        public int Id { get; set; }
        public int? StyleMasterId { get; set; }
        public string PostNumber { get; set; }
        public int? StaffId { get; set; }
        public DateTime? PostedDate { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        public int? CustomerId { get; set; }
    }
}