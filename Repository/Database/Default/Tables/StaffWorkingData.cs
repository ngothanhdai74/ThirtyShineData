﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class StaffWorkingData
    {
        [Key]
        public int Id { get; set; }
        public int? StaffId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? WorkDate { get; set; }
        public int? TotalBill { get; set; }
        public int? WorkHours { get; set; }
    }
}