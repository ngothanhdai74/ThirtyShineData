﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class IvCheckOut
    {
        [Key]
        public int Id { get; set; }
        public int? SalonId { get; set; }
        public int? WarehouseId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDelete { get; set; }
        public int? Week { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? DayOfWeek { get; set; }
    }
}