﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class StynextKpiConfig
    {
        [Key]
        public int Id { get; set; }
        public int KpiId { get; set; }
        [StringLength(10)]
        public string KpiName { get; set; }
        public int KpiType { get; set; }
        public int Point { get; set; }
        public int BottomLevel { get; set; }
        public int TopLevel { get; set; }
        public bool? IsDeleted { get; set; }
    }
}