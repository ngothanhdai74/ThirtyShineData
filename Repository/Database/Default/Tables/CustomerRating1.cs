﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("CustomerRating")]
    public partial class CustomerRating1
    {
        [Key]
        public int Id { get; set; }
        public int BillId { get; set; }
        public int CustomerId { get; set; }
        public int RatingTypeId { get; set; }
        public int RatingConfigPointId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiredTime { get; set; }
    }
}