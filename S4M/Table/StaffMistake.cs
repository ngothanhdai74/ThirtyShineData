﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class StaffMistake
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int? Point { get; set; }
        public string Description { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Images { get; set; }
        public int? FormMissTakeId { get; set; }
        public string Note { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}