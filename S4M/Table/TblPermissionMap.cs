﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class TblPermissionMap
    {
        public int MapId { get; set; }
        public int? PId { get; set; }
        public string PName { get; set; }
        public int? MId { get; set; }
        public string MName { get; set; }
        public string AId { get; set; }
        public bool? MapPublish { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}