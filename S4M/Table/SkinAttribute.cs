﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class SkinAttribute
    {
        public int Id { get; set; }
        public string SkinTypeName { get; set; }
        public int? ParentId { get; set; }
        public bool? IsDelete { get; set; }
        public bool? Status { get; set; }
        public int? Order { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}