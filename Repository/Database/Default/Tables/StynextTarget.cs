﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class StynextTarget
    {
        [Key]
        public int Id { get; set; }
        public int? SalonId { get; set; }
        public int? StaffId { get; set; }
        public int? StynextGroupId { get; set; }
        [Column(TypeName = "date")]
        public DateTime Month { get; set; }
        public double RevenueTarget { get; set; }
        [Column("R30Target")]
        public double R30target { get; set; }
        public int? NumberStaffWorking { get; set; }
        public bool? IsDeleted { get; set; }
    }
}