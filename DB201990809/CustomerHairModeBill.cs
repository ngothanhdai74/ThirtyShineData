﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class CustomerHairModeBill
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? HairStyleId { get; set; }
        public int? BillId { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? ModifiledDate { get; set; }
        public int? FaceTypeId { get; set; }
        public string Note { get; set; }
        public bool? IsMessage { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}