﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class StaffContractMap
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int? ContractId { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public DateTime? SignDate { get; set; }
        public bool IsSign { get; set; }
        public bool Active { get; set; }
        public bool IsDelete { get; set; }
        public bool? IsReceived { get; set; }
    }
}