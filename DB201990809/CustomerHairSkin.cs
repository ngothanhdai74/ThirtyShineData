﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class CustomerHairSkin
    {
        public int Id { get; set; }
        public string HairAttIds { get; set; }
        public string SkinAttIds { get; set; }
        public int? CustomerId { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}