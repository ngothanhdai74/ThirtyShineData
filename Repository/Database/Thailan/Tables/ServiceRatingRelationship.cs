﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Service_Rating_Relationship")]
    public partial class ServiceRatingRelationship
    {
        [Key]
        public int Id { get; set; }
        public int? BillServiceId { get; set; }
        public int? ServiceRatingId { get; set; }
        public int? SalonId { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}