﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class SpecialCustomer
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? CustomerTypeId { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsSms { get; set; }
        public int? Smsstatus { get; set; }
        public DateTime? SendDate { get; set; }
        public bool? Publish { get; set; }
        public int? BrowseId { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}