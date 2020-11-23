﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("DCustomerScore")]
    public partial class DcustomerScore
    {
        [Key]
        public int IdCustomerScore { get; set; }
        public int NumberUseServiceAtTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateOfBill { get; set; }
        public double CustomerScoreAtTime { get; set; }
        public int RatingScore { get; set; }
        public double StylistScore { get; set; }
        public int CustomerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Key]
        public int BillId { get; set; }
    }
}