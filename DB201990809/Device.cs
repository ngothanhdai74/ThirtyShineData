﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class Device
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public string ImeiOrMacIp { get; set; }
        public int? OwnerType { get; set; }
        public int? OwnerId { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UniqueKey { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDelete { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}