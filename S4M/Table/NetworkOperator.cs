﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class NetworkOperator
    {
        public int Id { get; set; }
        public string NetworkName { get; set; }
        public string ShortName { get; set; }
        public string Url { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsResend { get; set; }
        public bool? IsDefault { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}