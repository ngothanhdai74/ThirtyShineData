﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class StaffProfileMap
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int StatusProfileId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool IsDelete { get; set; }
    }
}