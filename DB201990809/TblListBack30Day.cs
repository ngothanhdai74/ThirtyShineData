﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class TblListBack30Day
    {
        public int Id { get; set; }
        public string CusName { get; set; }
        public string CusPhone { get; set; }
        public int? CusId { get; set; }
        public bool? Call { get; set; }
        public string Note { get; set; }
        public bool? Publish { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModyfiDate { get; set; }
        public DateTime? Date { get; set; }
        public int? SalonId { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}