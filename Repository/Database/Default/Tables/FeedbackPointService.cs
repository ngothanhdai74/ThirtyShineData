﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class FeedbackPointService
    {
        [Key]
        public int Id { get; set; }
        public int? SalonId { get; set; }
        public int? FeedbackQuantity { get; set; }
        [Column(TypeName = "date")]
        public DateTime? WorkDate { get; set; }
        public bool? IsDelete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
    }
}