﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class SuKienTeam
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public int? SalonId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
        public bool? Publish { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}