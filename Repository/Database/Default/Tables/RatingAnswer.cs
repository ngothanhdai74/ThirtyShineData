﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class RatingAnswer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(2000)]
        public string Answer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int Type { get; set; }
        public bool? Positive { get; set; }
    }
}