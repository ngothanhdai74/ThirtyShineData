﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class TblEmailReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Permission { get; set; }
        public int? SalonId { get; set; }
        public byte? IsDelete { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}