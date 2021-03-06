﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class MktCampaign
    {
        [Key]
        public int Id { get; set; }
        [StringLength(125)]
        public string Name { get; set; }
        [StringLength(125)]
        public string Label { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        public int MaxUsage { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }
        [StringLength(450)]
        public string Note { get; set; }
        public bool IsBookingPublish { get; set; }
        public string Image { get; set; }
        public int Type { get; set; }
        [StringLength(300)]
        public string CheckoutLabel { get; set; }
        [StringLength(500)]
        public string CustomerCondition { get; set; }
        public int? ServiceType { get; set; }
        public int? CampaignMaxUsage { get; set; }
        public int? CustomerType { get; set; }
    }
}